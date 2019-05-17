using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Attendance
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_sessions_guid { get; set; }

        public static List<Attendance> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_ATTENDANCE);
            return BuildFromReader(reader);
        }

        private static List<Attendance> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Attendance>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Attendance()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_events_guid = (string)row["fk_events_guid"],
                        fk_sessions_guid = (string)row["fk_sessions_guid"]
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Attendance attendance &&
                   this.guid == attendance.guid &&
                   this.timestamp == attendance.timestamp &&
                   this.fk_churches_guid == attendance.fk_churches_guid &&
                   this.fk_names_guid == attendance.fk_names_guid &&
                   this.fk_events_guid == attendance.fk_events_guid &&
                   this.fk_sessions_guid == attendance.fk_sessions_guid;
        }

        public override int GetHashCode()
        {
            var hashCode = -1083745242;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_events_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_sessions_guid);
            return hashCode;
        }
    }
}
