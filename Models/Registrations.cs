namespace DisciplesMerger.Models
{
    public class Registrations
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string ticketnumber { get; set; }
        public string advertising { get; set; }
        public string notes { get; set; }
    }
}
