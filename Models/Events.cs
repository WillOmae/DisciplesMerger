using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Events
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string fk_workers_guid2 { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string abbreviation { get; set; }
        public long? color { get; set; }
        public string description { get; set; }
        public double? date { get; set; }
        public string presenter { get; set; }
        public string venue { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string notes { get; set; }

        public static void Insert(Database database, HashSet<Events> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                   item.guid ,
                   item.timestamp ,
                   item.fk_churches_guid ,
                   item.fk_workers_guid ,
                   item.fk_workers_guid2 ,
                   item.type ,
                   item.title ,
                   item.abbreviation ,
                   item.color ,
                   item.description ,
                   item.date ,
                   item.presenter ,
                   item.venue ,
                   item.street ,
                   item.city ,
                   item.state ,
                   item.postal ,
                   item.country ,
                   item.coordinates ,
                   item.notes
            });
            }
            database.Create(DB_Statements.INSERT_EVENTS, parameters);
        }
        public static List<Events> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_EVENTS);
            return BuildFromReader(reader);
        }

        private static List<Events> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Events>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Events()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        fk_workers_guid2 = (string)row["fk_workers_guid2"],
                        type = row["type"] == DBNull.Value ? null : (string)row["type"],
                        title = row["title"] == DBNull.Value ? null : (string)row["title"],
                        abbreviation = row["abbreviation"] == DBNull.Value ? null : (string)row["abbreviation"],
                        color = row["color"] == DBNull.Value ? null : (long?)row["color"],
                        description = row["description"] == DBNull.Value ? null : (string)row["description"],
                        date = row["date"] == DBNull.Value ? null : (double?)row["date"],
                        presenter = row["presenter"] == DBNull.Value ? null : (string)row["presenter"],
                        venue = row["venue"] == DBNull.Value ? null : (string)row["venue"],
                        street = row["street"] == DBNull.Value ? null : (string)row["street"],
                        city = row["city"] == DBNull.Value ? null : (string)row["city"],
                        state = row["state"] == DBNull.Value ? null : (string)row["state"],
                        postal = row["postal"] == DBNull.Value ? null : (string)row["postal"],
                        country = row["country"] == DBNull.Value ? null : (string)row["country"],
                        coordinates = row["coordinates"] == DBNull.Value ? null : (string)row["coordinates"],
                        notes = row["notes"] == DBNull.Value ? null : (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Events events &&
                   this.guid == events.guid &&
                   this.timestamp == events.timestamp &&
                   this.fk_churches_guid == events.fk_churches_guid &&
                   this.fk_workers_guid == events.fk_workers_guid &&
                   this.fk_workers_guid2 == events.fk_workers_guid2 &&
                   this.type == events.type &&
                   this.title == events.title &&
                   this.abbreviation == events.abbreviation &&
                   this.color == events.color &&
                   this.description == events.description &&
                   this.date == events.date &&
                   this.presenter == events.presenter &&
                   this.venue == events.venue &&
                   this.street == events.street &&
                   this.city == events.city &&
                   this.state == events.state &&
                   this.postal == events.postal &&
                   this.country == events.country &&
                   this.coordinates == events.coordinates &&
                   this.notes == events.notes;
        }

        public override int GetHashCode()
        {
            var hashCode = -1941251384;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.abbreviation);
            hashCode = hashCode * -1521134295 + this.color.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.description);
            hashCode = hashCode * -1521134295 + this.date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.presenter);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.venue);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.postal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.coordinates);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            return hashCode;
        }
    }
}
