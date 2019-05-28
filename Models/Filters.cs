using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Filters
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string andor { get; set; }
        public string categories { get; set; }
        public string columns { get; set; }
        public string operators { get; set; }
        public string queries { get; set; }

        public static void Insert(Database database, HashSet<Filters> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid ,
                    item.timestamp ,
                    item.fk_workers_guid ,
                    item.name ,
                    item.andor ,
                    item.categories ,
                    item.columns ,
                    item.operators ,
                    item.queries ,
                });
            }
            database.Create(DB_Statements.INSERT_FILTERS, parameters);
        }

        public static List<Filters> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_FILTERS);
            return BuildFromReader(reader);
        }

        private static List<Filters> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Filters>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Filters()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        name = row["name"] == DBNull.Value ? null : (string)row["name"],
                        andor = row["andor"] == DBNull.Value ? null : (string)row["andor"],
                        categories = row["categories"] == DBNull.Value ? null : (string)row["categories"],
                        columns = row["columns"] == DBNull.Value ? null : (string)row["columns"],
                        operators = row["operators"] == DBNull.Value ? null : (string)row["operators"],
                        queries = row["queries"] == DBNull.Value ? null : (string)row["queries"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Filters filters &&
                   this.guid == filters.guid &&
                   //this.timestamp == filters.timestamp &&
                   this.fk_workers_guid == filters.fk_workers_guid &&
                   this.name == filters.name &&
                   this.andor == filters.andor &&
                   this.categories == filters.categories &&
                   this.columns == filters.columns &&
                   this.operators == filters.operators &&
                   this.queries == filters.queries;
        }

        public override int GetHashCode()
        {
            var hashCode = 690352772;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            //hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.andor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.categories);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.columns);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.operators);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.queries);
            return hashCode;
        }
    }
}
