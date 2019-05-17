namespace DisciplesMerger.Models
{
    public class Smallgroups
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string street { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string day { get; set; }
        public string time { get; set; }
        public string materials { get; set; }
        public string notes { get; set; }
    }
}
