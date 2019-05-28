using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Sessions
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_events_guid { get; set; }
        public long? night { get; set; }
        public double? date { get; set; }
        public string title { get; set; }
        public string subject { get; set; }
        public string venue { get; set; }
        public string presenter { get; set; }
        public string fk_workers_guid { get; set; }
        public string fk_lessons_guid { get; set; }
        public string materials { get; set; }
        public string notes { get; set; }
        public static void Insert(Database database, HashSet<Sessions> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid,
                   item.timestamp,
                   item.fk_churches_guid,
                   item.fk_events_guid,
                   item.night,
                   item.date,
                   item.title,
                   item.subject,
                   item.venue,
                   item.presenter,
                   item.fk_workers_guid,
                   item.fk_lessons_guid,
                   item.materials,
                   item.notes,
                });
            }
            database.Create(DB_Statements.INSERT_SESSIONS, parameters);
        }

        public static List<Sessions> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_SESSIONS);
            return BuildFromReader(reader);
        }

        private static List<Sessions> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Sessions>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Sessions()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_events_guid = row["fk_events_guid"] == DBNull.Value ? null : (string)row["fk_events_guid"],
                        night = row["night"] == DBNull.Value ? null : (long?)row["night"],
                        date = row["date"] == DBNull.Value ? null : (double?)row["date"],
                        title = row["title"] == DBNull.Value ? null : (string)row["title"],
                        subject = row["subject"] == DBNull.Value ? null : (string)row["subject"],
                        venue = row["venue"] == DBNull.Value ? null : (string)row["venue"],
                        presenter = row["presenter"] == DBNull.Value ? null : (string)row["presenter"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        fk_lessons_guid = row["fk_lessons_guid"] == DBNull.Value ? null : (string)row["fk_lessons_guid"],
                        materials = row["materials"] == DBNull.Value ? null : (string)row["materials"],
                        notes = row["notes"] == DBNull.Value ? null : (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Sessions sessions &&
                   this.guid == sessions.guid &&
                   //this.timestamp == sessions.timestamp &&
                   this.fk_churches_guid == sessions.fk_churches_guid &&
                   this.fk_events_guid == sessions.fk_events_guid &&
                   this.night == sessions.night &&
                   this.date == sessions.date &&
                   this.title == sessions.title &&
                   this.subject == sessions.subject &&
                   this.venue == sessions.venue &&
                   this.presenter == sessions.presenter &&
                   this.fk_workers_guid == sessions.fk_workers_guid &&
                   this.fk_lessons_guid == sessions.fk_lessons_guid &&
                   this.materials == sessions.materials &&
                   this.notes == sessions.notes;
        }

        public override int GetHashCode()
        {
            var hashCode = -1274052789;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            //hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_events_guid);
            hashCode = hashCode * -1521134295 + this.night.GetHashCode();
            hashCode = hashCode * -1521134295 + this.date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.subject);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.venue);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.presenter);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_lessons_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.materials);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            return hashCode;
        }
    }
}
