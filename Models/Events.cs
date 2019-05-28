using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Events
    {
        private string guid { get; set; }
        private long? timestamp { get; set; }
        private string fk_churches_guid { get; set; }
        private string fk_workers_guid { get; set; }
        private string fk_workers_guid2 { get; set; }
        private string type { get; set; }
        private string title { get; set; }
        private string abbreviation { get; set; }
        private long? color { get; set; }
        private string description { get; set; }
        private double? date { get; set; }
        private string presenter { get; set; }
        private string venue { get; set; }
        private string street { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string postal { get; set; }
        private string country { get; set; }
        private string coordinates { get; set; }
        private string notes { get; set; }

        public static void Insert(Database database, HashSet<Events> set)
        {
            var parameters = new List<List<object>>();
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
            var reader = database.Read(DB_Statements.READ_EVENTS);
            return BuildFromReader(reader);
        }

        private static List<Events> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Events>();
            if (rows == null) return result;
            foreach (var row in rows)
            {
                var item = new Events();
                item.guid = row["guid"] as string;
                item.timestamp = row["timestamp"] as long?;
                item.fk_churches_guid = row["fk_churches_guid"] as string;
                item.fk_workers_guid = row["fk_workers_guid"] as string;
                item.fk_workers_guid2 = row["fk_workers_guid2"] as string;
                item.type = row["type"] as string;
                item.title = row["title"] as string;
                item.abbreviation = row["abbreviation"] as string;
                item.color = row["color"] as long?;
                item.description = row["description"] as string;
                item.date = row["date"] as double?;
                item.presenter = row["presenter"] as string;
                item.venue = row["venue"] as string;
                item.street = row["street"] as string;
                item.city = row["city"] as string;
                item.state = row["state"] as string;
                item.postal = row["postal"] as string;
                item.country = row["country"] as string;
                item.coordinates = row["coordinates"] as string;
                item.notes = row["notes"] as string;
                result.Add(item);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Events events &&
                   this.guid == events.guid &&
                   //this.timestamp == events.timestamp &&
                   this.fk_churches_guid == events.fk_churches_guid &&
                   this.fk_workers_guid == events.fk_workers_guid &&
                   this.fk_workers_guid2 == events.fk_workers_guid2 &&
                   this.type == events.type &&
                   this.title == events.title &&
                   this.abbreviation == events.abbreviation &&
                   this.color == events.color &&
                   this.description == events.description &&
                   //this.date == events.date &&
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
            //hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.abbreviation);
            hashCode = hashCode * -1521134295 + this.color.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.description);
            //hashCode = hashCode * -1521134295 + this.date.GetHashCode();
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
