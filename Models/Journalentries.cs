using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Journalentries
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_smallgroups_guid { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string duration { get; set; }
        public string notes { get; set; }
        public string completed { get; set; }

        public static void Insert(Database database, HashSet<Journalentries> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid,
                   item.timestamp,
                   item.fk_churches_guid,
                   item.fk_names_guid,
                   item.fk_events_guid,
                   item.fk_smallgroups_guid,
                   item.type,
                   item.title,
                   item.date,
                   item.duration,
                   item.notes,
                   item.completed,
                });
            }
            database.Create(DB_Statements.INSERT_JOURNALENTRIES, parameters);
        }

        public static List<Journalentries> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_JOURNALENTRIES);
            return BuildFromReader(reader);
        }

        private static List<Journalentries> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Journalentries>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Journalentries()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_events_guid = (string)row["fk_events_guid"],
                        fk_smallgroups_guid = (string)row["fk_smallgroups_guid"],
                        type = (string)row["type"],
                        title = (string)row["title"],
                        date = (string)row["date"],
                        duration = (string)row["duration"],
                        notes = (string)row["notes"],
                        completed = (string)row["completed"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Journalentries journalentries &&
                   this.guid == journalentries.guid &&
                   this.timestamp == journalentries.timestamp &&
                   this.fk_churches_guid == journalentries.fk_churches_guid &&
                   this.fk_names_guid == journalentries.fk_names_guid &&
                   this.fk_events_guid == journalentries.fk_events_guid &&
                   this.fk_smallgroups_guid == journalentries.fk_smallgroups_guid &&
                   this.type == journalentries.type &&
                   this.title == journalentries.title &&
                   this.date == journalentries.date &&
                   this.duration == journalentries.duration &&
                   this.notes == journalentries.notes &&
                   this.completed == journalentries.completed;
        }

        public override int GetHashCode()
        {
            var hashCode = 1776832582;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_events_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_smallgroups_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.date);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.duration);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.completed);
            return hashCode;
        }
    }
}
