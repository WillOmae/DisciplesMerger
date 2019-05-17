using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Smallgroups
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string street { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string day { get; set; }
        public string time { get; set; }
        public string materials { get; set; }
        public string notes { get; set; }


        public static List<Smallgroups> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_SMALLGROUPS);
            return BuildFromReader(reader);
        }

        private static List<Smallgroups> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Smallgroups>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Smallgroups()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        name = (string)row["name"],
                        description = (string)row["description"],
                        location = (string)row["location"],
                        street = (string)row["street"],
                        unit = (string)row["unit"],
                        city = (string)row["city"],
                        state = (string)row["state"],
                        postal = (string)row["postal"],
                        country = (string)row["country"],
                        coordinates = (string)row["coordinates"],
                        day = (string)row["day"],
                        time = (string)row["time"],
                        materials = (string)row["materials"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Smallgroups smallgroups &&
                   this.guid == smallgroups.guid &&
                   this.timestamp == smallgroups.timestamp &&
                   this.fk_churches_guid == smallgroups.fk_churches_guid &&
                   this.fk_names_guid == smallgroups.fk_names_guid &&
                   this.fk_workers_guid == smallgroups.fk_workers_guid &&
                   this.name == smallgroups.name &&
                   this.description == smallgroups.description &&
                   this.location == smallgroups.location &&
                   this.street == smallgroups.street &&
                   this.unit == smallgroups.unit &&
                   this.city == smallgroups.city &&
                   this.state == smallgroups.state &&
                   this.postal == smallgroups.postal &&
                   this.country == smallgroups.country &&
                   this.coordinates == smallgroups.coordinates &&
                   this.day == smallgroups.day &&
                   this.time == smallgroups.time &&
                   this.materials == smallgroups.materials &&
                   this.notes == smallgroups.notes;
        }

        public override int GetHashCode()
        {
            var hashCode = 1917642229;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.location);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.unit);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.postal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.coordinates);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.day);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.time);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.materials);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            return hashCode;
        }
    }
}
