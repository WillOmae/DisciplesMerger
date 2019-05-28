using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Registrations
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string ticketnumber { get; set; }
        public string advertising { get; set; }
        public string notes { get; set; }
        public static void Insert(Database database, HashSet<Registrations> set)
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
                   item.fk_workers_guid,
                   item.ticketnumber,
                   item.advertising,
                   item.notes,
                });
            }
            database.Create(DB_Statements.INSERT_REGISTRATIONS, parameters);
        }

        public static List<Registrations> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_REGISTRATIONS);
            return BuildFromReader(reader);
        }

        private static List<Registrations> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Registrations>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Registrations()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_names_guid = row["fk_names_guid"] == DBNull.Value ? null : (string)row["fk_names_guid"],
                        fk_events_guid = row["fk_events_guid"] == DBNull.Value ? null : (string)row["fk_events_guid"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        ticketnumber = row["ticketnumber"] == DBNull.Value ? null : (string)row["ticketnumber"],
                        advertising = row["advertising"] == DBNull.Value ? null : (string)row["advertising"],
                        notes = row["notes"] == DBNull.Value ? null : (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Registrations registrations &&
                   this.guid == registrations.guid &&
                   //this.timestamp == registrations.timestamp &&
                   this.fk_churches_guid == registrations.fk_churches_guid &&
                   this.fk_names_guid == registrations.fk_names_guid &&
                   this.fk_events_guid == registrations.fk_events_guid &&
                   this.fk_workers_guid == registrations.fk_workers_guid &&
                   this.ticketnumber == registrations.ticketnumber &&
                   this.advertising == registrations.advertising &&
                   this.notes == registrations.notes;
        }

        public override int GetHashCode()
        {
            var hashCode = -1671173987;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            //hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_events_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ticketnumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.advertising);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            return hashCode;
        }
    }
}
