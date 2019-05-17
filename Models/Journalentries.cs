using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Journalentries
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_smallgroups_guid { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string duration { get; set; }
        public string notes { get; set; }
        public string completed { get; set; }


        public static List<Journalentries> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_JOURNALENTRIES);
            return BuildFromReader(reader);
        }

        private static List<Journalentries> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            List<Journalentries> result = new List<Journalentries>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Journalentries()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_events_guid = (string)row["fk_events_guid"],
                        fk_smallgroups_guid = (string)row["fk_smallgroups_guid"],
                        type = (string)row["type"],
                        title = (string)row["title"],
                        date = (string)row["date"],
                        duration = (string)row["duration"],
                        notes = (string)row["notes"],
                        completed = (string)row["completed"],
                    });
                }
            }
            return result;
        }
    }
}
