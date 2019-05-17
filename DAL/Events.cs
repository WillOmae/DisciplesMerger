namespace DisciplesMerger.DAL
{
    public class Events
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
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
    }
}
