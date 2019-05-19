using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Interests
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string interest { get; set; }
        public string interestother { get; set; }
        public string interestcategory { get; set; }

        public static void Insert(Database database, HashSet<Interests> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid ,
                   item.timestamp ,
                   item.fk_churches_guid ,
                   item.fk_names_guid ,
                   item.interest ,
                   item.interestother ,
                   item.interestcategory,
                });
            }
            database.Create(DB_Statements.INSERT_INTERESTS, parameters);
        }

        public static List<Interests> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_INTERESTS);
            return BuildFromReader(reader);
        }

        private static List<Interests> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Interests>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Interests()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_names_guid = row["fk_names_guid"] == DBNull.Value ? null : (string)row["fk_names_guid"],
                        interest = row["interest"] == DBNull.Value ? null : (string)row["interest"],
                        interestother = row["interestother"] == DBNull.Value ? null : (string)row["interestother"],
                        interestcategory = row["interestcategory"] == DBNull.Value ? null : (string)row["interestcategory"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Interests interests &&
                   this.guid == interests.guid &&
                   this.timestamp == interests.timestamp &&
                   this.fk_churches_guid == interests.fk_churches_guid &&
                   this.fk_names_guid == interests.fk_names_guid &&
                   this.interest == interests.interest &&
                   this.interestother == interests.interestother &&
                   this.interestcategory == interests.interestcategory;
        }

        public override int GetHashCode()
        {
            var hashCode = -1727443409;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.interest);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.interestother);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.interestcategory);
            return hashCode;
        }
    }
}
