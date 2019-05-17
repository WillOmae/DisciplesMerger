namespace DisciplesMerger.DAL
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
    }
}
