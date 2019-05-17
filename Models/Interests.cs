using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Interests
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string interest { get; set; }
        public string interestother { get; set; }
        public string interestcategory { get; set; }


        public static HashSet<Interests> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_INTERESTS);
            return BuildFromReader(reader);
        }

        private static HashSet<Interests> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Interests> result = new HashSet<Interests>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Interests()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        interest = (string)row["interest"],
                        interestother = (string)row["interestother"],
                        interestcategory = (string)row["interestcategory"],
                    });
                }
            }
            return result;
        }
    }
}
