using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Events
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string fk_workers_guid2 { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string abbreviation { get; set; }
        public string color { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string presenter { get; set; }
        public string venue { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string notes { get; set; }

        public static HashSet<Events> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_EVENTS);
            return BuildFromReader(reader);
        }

        private static HashSet<Events> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Events> result = new HashSet<Events>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Events()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        fk_workers_guid2 = (string)row["fk_workers_guid2"],
                        type = (string)row["type"],
                        title = (string)row["title"],
                        abbreviation = (string)row["abbreviation"],
                        color = (string)row["color"],
                        description = (string)row["description"],
                        date = (string)row["date"],
                        presenter = (string)row["presenter"],
                        venue = (string)row["venue"],
                        street = (string)row["street"],
                        city = (string)row["city"],
                        state = (string)row["state"],
                        postal = (string)row["postal"],
                        country = (string)row["country"],
                        coordinates = (string)row["coordinates"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }
    }
}
