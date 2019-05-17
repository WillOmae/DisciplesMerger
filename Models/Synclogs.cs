using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Synclogs
    {
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string tablename { get; set; }
        public string fk_guid { get; set; }
        public string action { get; set; }


        public static List<Synclogs> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_SYNCLOGS);
            return BuildFromReader(reader);
        }

        private static List<Synclogs> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Synclogs>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Synclogs()
                    {
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        tablename = (string)row["tablename"],
                        fk_guid = (string)row["fk_guid"],
                        action = (string)row["action"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Synclogs synclogs &&
                   this.timestamp == synclogs.timestamp &&
                   this.fk_churches_guid == synclogs.fk_churches_guid &&
                   this.tablename == synclogs.tablename &&
                   this.fk_guid == synclogs.fk_guid &&
                   this.action == synclogs.action;
        }

        public override int GetHashCode()
        {
            var hashCode = -705254040;
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.tablename);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.action);
            return hashCode;
        }
    }
}
