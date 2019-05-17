namespace DisciplesMerger.DAL
{
    public class Interests
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string interest { get; set; }
        public string interestother { get; set; }
        public string interestcategory { get; set; }
    }
}
