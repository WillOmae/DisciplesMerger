using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Groups
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string guids { get; set; }

        public static void Insert(Database database, HashSet<Groups> set)
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
                    item.type ,
                    item.guids ,
            });
            }
            database.Create(DB_Statements.INSERT_GROUPS, parameters);
        }

        public static List<Groups> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_GROUPS);
            return BuildFromReader(reader);
        }

        private static List<Groups> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Groups>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Groups()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        name = row["name"] == DBNull.Value ? null : (string)row["name"],
                        type = row["type"] == DBNull.Value ? null : (string)row["type"],
                        guids = row["guids"] == DBNull.Value ? null : (string)row["guids"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Groups groups &&
                   this.guid == groups.guid &&
                   this.timestamp == groups.timestamp &&
                   this.fk_workers_guid == groups.fk_workers_guid &&
                   this.name == groups.name &&
                   this.type == groups.type &&
                   this.guids == groups.guids;
        }

        public override int GetHashCode()
        {
            var hashCode = -2005488443;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guids);
            return hashCode;
        }
    }
}
