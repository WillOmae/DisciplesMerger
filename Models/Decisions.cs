namespace DisciplesMerger.Models
{
    public class Decisions
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_registrations_guid { get; set; }
        public string fk_contacts_guid { get; set; }
        public string fk_sessions_guid { get; set; }
        public string decision { get; set; }
        public string decisionother { get; set; }
        public string decisioncategory { get; set; }
    }
}
