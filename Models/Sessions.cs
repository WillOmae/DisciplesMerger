using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Sessions
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string night { get; set; }
        public string date { get; set; }
        public string title { get; set; }
        public string subject { get; set; }
        public string venue { get; set; }
        public string presenter { get; set; }
        public string fk_workers_guid { get; set; }
        public string fk_lessons_guid { get; set; }
        public string materials { get; set; }
        public string notes { get; set; }


        public static HashSet<Sessions> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_SESSIONS);
            return BuildFromReader(reader);
        }

        private static HashSet<Sessions> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Sessions> result = new HashSet<Sessions>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Sessions()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_events_guid = (string)row["fk_events_guid"],
                        night = (string)row["night"],
                        date = (string)row["date"],
                        title = (string)row["title"],
                        subject = (string)row["subject"],
                        venue = (string)row["venue"],
                        presenter = (string)row["presenter"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        fk_lessons_guid = (string)row["fk_lessons_guid"],
                        materials = (string)row["materials"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }
    }
}
