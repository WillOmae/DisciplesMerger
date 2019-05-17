namespace DisciplesMerger.DAL
{
    public class Sessions
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
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
    }
}
