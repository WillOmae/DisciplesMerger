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
    }
}
