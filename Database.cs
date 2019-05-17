using System.Collections.Generic;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace DisciplesMerger
{
    public class Database
    {
        private readonly string connectionString;

        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="dbName">The database name</param>
        public Database(string dbName)
        {
            connectionString = GenerateConnectionString(dbName);
        }

        /// <summary>
        /// Programmatically creates the connection string.
        /// </summary>
        /// <returns>The connection string.</returns>
        private string GenerateConnectionString(string dbName)
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder
            {
                // set the db name
                DataSource = dbName,
                // this will create the database if it is non-existent
                FailIfMissing = false,
                // allow foreign keys
                ForeignKeys = true,
                // set the journal mode
                JournalMode = SQLiteJournalModeEnum.Delete,
                // sqlite version to use
                Version = 3
            };
            return builder.ToString();
        }

        /// <summary>
        /// Queries the sql statement, getting all instances of parameter names denoted by @.
        /// </summary>
        /// <param name="sql">The sql to be queried.</param>
        /// <returns>String array of parameter names or null for no match.</returns>
        private string[] ExtractParameterNames(string sql)
        {
            // create regex for parameter names
            Regex regex = new Regex(@"@\w*");
            MatchCollection matches = regex.Matches(sql);
            if (matches.Count > 0)
            {
                string[] parameterNames = new string[matches.Count];
                for (int i = 0; i < parameterNames.Length; i++)
                {
                    parameterNames[i] = matches[i].Value;
                }
                return parameterNames;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Database create method.
        /// </summary>
        /// <param name="sql">Sql statement with parameter names when applicable.</param>
        /// <param name="parameters">List of parameters.</param>
        /// <param name="insertId">(out param) The ID of the last inserted row in the connection if successful; -1 otherwise.</param>
        /// <returns>True if successful; false otherwise.</returns>
        public void Create(string sql, List<List<object>> listOfListOfParameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        string[] parameterNames = ExtractParameterNames(sql);
                        for (int i = 0; i < listOfListOfParameters.Count; i++)
                        {
                            var listOfParameters = listOfListOfParameters[i];
                            command.CommandText = sql;
                            for (int j = 0; j < listOfParameters.Count; j++)
                            {
                                command.Parameters.AddWithValue(parameterNames[j], listOfParameters[j]);
                            }
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
        }

        /// <summary>
        /// Database read method.
        /// </summary>
        /// <param name="sql">Sql statement with parameter names where applicable.</param>
        /// <param name="parameters">List of parameters.</param>
        /// <returns>SQLiteDataReader if successful; null otherwise</returns>
        public List<Dictionary<string, object>> Read(string sql)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // dictionary is for column cells, list for rows
                            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                            while (reader.Read())
                            {
                                Dictionary<string, object> row = new Dictionary<string, object>(reader.FieldCount);
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row.Add(reader.GetName(i), reader.GetValue(i));
                                }
                                rows.Add(row);
                            }
                            if (rows.Count > 0)
                            {
                                return rows;
                            }
                        }
                        return null;
                    }
                }
            }
        }
    }
}
