using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Groups
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string guids { get; set; }


        public static List<Groups> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_GROUPS);
            return BuildFromReader(reader);
        }

        private static List<Groups> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            List<Groups> result = new List<Groups>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Groups()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        name = (string)row["name"],
                        type = (string)row["type"],
                        guids = (string)row["guids"],
                    });
                }
            }
            return result;
        }
    }
}
