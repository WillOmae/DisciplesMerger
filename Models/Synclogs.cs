using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Synclogs
    {
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string tablename { get; set; }
        public string fk_guid { get; set; }
        public string action { get; set; }


        public static List<Synclogs> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_SYNCLOGS);
            return BuildFromReader(reader);
        }

        private static List<Synclogs> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Synclogs>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Synclogs()
                    {
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        tablename = (string)row["tablename"],
                        fk_guid = (string)row["fk_guid"],
                        action = (string)row["action"],
                    });
                }
            }
            return result;
        }
    }
}
