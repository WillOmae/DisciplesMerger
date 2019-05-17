namespace DisciplesMerger.DAL
{
    public class Relationships
    {
        public int id { get; set; }
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_names_guid2 { get; set; }
        public string type { get; set; }
        public string sort { get; set; }
    }
}
