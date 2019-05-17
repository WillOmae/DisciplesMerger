using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Metadata
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string version { get; set; }
        public string shared { get; set; }
        public string account_id { get; set; }
        public string lastsync { get; set; }
        public string needssync { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string street { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public string notes { get; set; }


        public static List<Metadata> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_METADATA);
            return BuildFromReader(reader);
        }

        private static List<Metadata> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            List<Metadata> result = new List<Metadata>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Metadata()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        version = (string)row["version"],
                        shared = (string)row["shared"],
                        account_id = (string)row["account_id"],
                        lastsync = (string)row["lastsync"],
                        needssync = (string)row["needssync"],
                        name = (string)row["name"],
                        description = (string)row["description"],
                        street = (string)row["street"],
                        unit = (string)row["unit"],
                        city = (string)row["city"],
                        state = (string)row["state"],
                        postal = (string)row["postal"],
                        country = (string)row["country"],
                        coordinates = (string)row["coordinates"],
                        phone1 = (string)row["phone1"],
                        phone2 = (string)row["phone2"],
                        email = (string)row["email"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }
    }
}
