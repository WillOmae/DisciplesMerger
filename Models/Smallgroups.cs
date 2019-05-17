using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Smallgroups
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string street { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string day { get; set; }
        public string time { get; set; }
        public string materials { get; set; }
        public string notes { get; set; }


        public static List<Smallgroups> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_SMALLGROUPS);
            return BuildFromReader(reader);
        }

        private static List<Smallgroups> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            List<Smallgroups> result = new List<Smallgroups>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Smallgroups()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        name = (string)row["name"],
                        description = (string)row["description"],
                        location = (string)row["location"],
                        street = (string)row["street"],
                        unit = (string)row["unit"],
                        city = (string)row["city"],
                        state = (string)row["state"],
                        postal = (string)row["postal"],
                        country = (string)row["country"],
                        coordinates = (string)row["coordinates"],
                        day = (string)row["day"],
                        time = (string)row["time"],
                        materials = (string)row["materials"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }
    }
}
