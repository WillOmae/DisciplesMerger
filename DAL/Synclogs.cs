namespace DisciplesMerger.DAL
{
    public class Synclogs
    {
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string tablename { get; set; }
        public string fk_guid { get; set; }
        public string action { get; set; }
    }
}
