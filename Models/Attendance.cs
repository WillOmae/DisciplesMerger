namespace DisciplesMerger.Models
{
    public class Attendance
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_sessions_guid { get; set; }
    }
}
