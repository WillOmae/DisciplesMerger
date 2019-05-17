using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Decisions
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_registrations_guid { get; set; }
        public string fk_contacts_guid { get; set; }
        public string fk_sessions_guid { get; set; }
        public string decision { get; set; }
        public string decisionother { get; set; }
        public string decisioncategory { get; set; }

        public static List<Decisions> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_DECISIONS);
            return BuildFromReader(reader);
        }

        private static List<Decisions> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            List<Decisions> result = new List<Decisions>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Decisions()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_registrations_guid = (string)row["fk_registrations_guid"],
                        fk_contacts_guid = (string)row["fk_contacts_guid"],
                        fk_sessions_guid = (string)row["fk_sessions_guid"],
                        decision = (string)row["decision"],
                        decisionother = (string)row["decisionother"],
                        decisioncategory = (string)row["decisioncategory"],
                    });
                }
            }
            return result;
        }
    }
}
