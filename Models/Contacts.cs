using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Contacts
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string date { get; set; }
        public string duration { get; set; }
        public string type { get; set; }
        public string studytype { get; set; }
        public string fk_studyseries_guid { get; set; }
        public string studynumber { get; set; }
        public string fk_studytopics_guid { get; set; }
        public string studytopicother { get; set; }
        public string completed { get; set; }
        public string notes { get; set; }

        public static HashSet<Contacts> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_CONTACTS);
            return BuildFromReader(reader);
        }

        private static HashSet<Contacts> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Contacts> result = new HashSet<Contacts>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Contacts()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        date = (string)row["date"],
                        duration = (string)row["duration"],
                        type = (string)row["type"],
                        studytype = (string)row["studytype"],
                        fk_studyseries_guid = (string)row["fk_studyseries_guid"],
                        studynumber = (string)row["studynumber"],
                        fk_studytopics_guid = (string)row["fk_studytopics_guid"],
                        studytopicother = (string)row["studytopicother"],
                        completed = (string)row["completed"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }
    }
}
