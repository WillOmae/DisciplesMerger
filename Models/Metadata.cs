using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Metadata
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string version { get; set; }
        public string shared { get; set; }
        public string account_id { get; set; }
        public string lastsync { get; set; }
        public string needssync { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string street { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public string notes { get; set; }

        public static void Insert(Database database, HashSet<Metadata> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid,
                   item.timestamp,
                   item.version,
                   item.shared,
                   item.account_id,
                   item.lastsync,
                   item.needssync,
                   item.name,
                   item.description,
                   item.street,
                   item.unit,
                   item.city,
                   item.state,
                   item.postal,
                   item.country,
                   item.coordinates,
                   item.phone1,
                   item.phone2,
                   item.email,
                   item.notes,
                });
            }
            database.Create(DB_Statements.INSERT_METADATA, parameters);
        }

        public static List<Metadata> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_METADATA);
            return BuildFromReader(reader);
        }

        private static List<Metadata> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Metadata>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Metadata()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        version = (string)row["version"],
                        shared = (string)row["shared"],
                        account_id = (string)row["account_id"],
                        lastsync = (string)row["lastsync"],
                        needssync = (string)row["needssync"],
                        name = (string)row["name"],
                        description = (string)row["description"],
                        street = (string)row["street"],
                        unit = (string)row["unit"],
                        city = (string)row["city"],
                        state = (string)row["state"],
                        postal = (string)row["postal"],
                        country = (string)row["country"],
                        coordinates = (string)row["coordinates"],
                        phone1 = (string)row["phone1"],
                        phone2 = (string)row["phone2"],
                        email = (string)row["email"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Metadata metadata &&
                   this.guid == metadata.guid &&
                   this.timestamp == metadata.timestamp &&
                   this.version == metadata.version &&
                   this.shared == metadata.shared &&
                   this.account_id == metadata.account_id &&
                   this.lastsync == metadata.lastsync &&
                   this.needssync == metadata.needssync &&
                   this.name == metadata.name &&
                   this.description == metadata.description &&
                   this.street == metadata.street &&
                   this.unit == metadata.unit &&
                   this.city == metadata.city &&
                   this.state == metadata.state &&
                   this.postal == metadata.postal &&
                   this.country == metadata.country &&
                   this.coordinates == metadata.coordinates &&
                   this.phone1 == metadata.phone1 &&
                   this.phone2 == metadata.phone2 &&
                   this.email == metadata.email &&
                   this.notes == metadata.notes;
        }

        public override int GetHashCode()
        {
            var hashCode = -1307005186;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.version);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.shared);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.account_id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.lastsync);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.needssync);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.unit);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.postal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.coordinates);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.phone1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.phone2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            return hashCode;
        }
    }
}
