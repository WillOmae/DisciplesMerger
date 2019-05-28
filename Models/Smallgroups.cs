using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Smallgroups
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
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
        public static void Insert(Database database, HashSet<Smallgroups> set)
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
                   item.fk_workers_guid,
                   item.name,
                   item.description,
                   item.location,
                   item.street,
                   item.unit,
                   item.city,
                   item.state,
                   item.postal,
                   item.country,
                   item.coordinates,
                   item.day,
                   item.time,
                   item.materials,
                   item.notes,
                });
            }
            database.Create(DB_Statements.INSERT_SMALLGROUPS, parameters);
        }

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
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_names_guid = row["fk_names_guid"] == DBNull.Value ? null : (string)row["fk_names_guid"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        name = row["name"] == DBNull.Value ? null : (string)row["name"],
                        description = row["description"] == DBNull.Value ? null : (string)row["description"],
                        location = row["location"] == DBNull.Value ? null : (string)row["location"],
                        street = row["street"] == DBNull.Value ? null : (string)row["street"],
                        unit = row["unit"] == DBNull.Value ? null : (string)row["unit"],
                        city = row["city"] == DBNull.Value ? null : (string)row["city"],
                        state = row["state"] == DBNull.Value ? null : (string)row["state"],
                        postal = row["postal"] == DBNull.Value ? null : (string)row["postal"],
                        country = row["country"] == DBNull.Value ? null : (string)row["country"],
                        coordinates = row["coordinates"] == DBNull.Value ? null : (string)row["coordinates"],
                        day = row["day"] == DBNull.Value ? null : (string)row["day"],
                        time = row["time"] == DBNull.Value ? null : (string)row["time"],
                        materials = row["materials"] == DBNull.Value ? null : (string)row["materials"],
                        notes = row["notes"] == DBNull.Value ? null : (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Smallgroups smallgroups &&
                   this.guid == smallgroups.guid &&
                   //this.timestamp == smallgroups.timestamp &&
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
            //hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
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
