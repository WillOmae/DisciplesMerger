using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Relationships
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_names_guid2 { get; set; }
        public string type { get; set; }
        public string sort { get; set; }
        public static void Insert(Database database, HashSet<Relationships> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid,
                   item.timestamp,
                   item.fk_churches_guid,
                   item.fk_names_guid,
                   item.fk_names_guid2,
                   item.type,
                   item.sort,
                });
            }
            database.Create(DB_Statements.INSERT_RELATIONSHIPS, parameters);
        }

        public static List<Relationships> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_RELATIONSHIPS);
            return BuildFromReader(reader);
        }

        private static List<Relationships> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Relationships>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Relationships()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_names_guid = row["fk_names_guid"] == DBNull.Value ? null : (string)row["fk_names_guid"],
                        fk_names_guid2 = (string)row["fk_names_guid2"],
                        type = row["type"] == DBNull.Value ? null : (string)row["type"],
                        sort = row["sort"] == DBNull.Value ? null : (string)row["sort"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Relationships relationships &&
                   this.guid == relationships.guid &&
                   this.timestamp == relationships.timestamp &&
                   this.fk_churches_guid == relationships.fk_churches_guid &&
                   this.fk_names_guid == relationships.fk_names_guid &&
                   this.fk_names_guid2 == relationships.fk_names_guid2 &&
                   this.type == relationships.type &&
                   this.sort == relationships.sort;
        }

        public override int GetHashCode()
        {
            var hashCode = -849420713;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.sort);
            return hashCode;
        }
    }
}
