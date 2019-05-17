using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Decisions
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_registrations_guid { get; set; }
        public string fk_contacts_guid { get; set; }
        public string fk_sessions_guid { get; set; }
        public string decision { get; set; }
        public string decisionother { get; set; }
        public string decisioncategory { get; set; }

        public static void Insert(Database database, HashSet<Decisions> set)
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
                    item.fk_names_guid,
                    item.fk_registrations_guid,
                    item.fk_contacts_guid,
                    item.fk_sessions_guid,
                    item.decision,
                    item.decisionother,
                    item.decisioncategory,
                });
            }
            database.Create(DB_Statements.INSERT_DECISIONS, parameters);
        }
        public static List<Decisions> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_DECISIONS);
            return BuildFromReader(reader);
        }

        private static List<Decisions> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Decisions>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Decisions()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_registrations_guid = (string)row["fk_registrations_guid"],
                        fk_contacts_guid = (string)row["fk_contacts_guid"],
                        fk_sessions_guid = (string)row["fk_sessions_guid"],
                        decision = (string)row["decision"],
                        decisionother = (string)row["decisionother"],
                        decisioncategory = (string)row["decisioncategory"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Decisions decisions &&
                   this.guid == decisions.guid &&
                   this.timestamp == decisions.timestamp &&
                   this.fk_churches_guid == decisions.fk_churches_guid &&
                   this.fk_names_guid == decisions.fk_names_guid &&
                   this.fk_registrations_guid == decisions.fk_registrations_guid &&
                   this.fk_contacts_guid == decisions.fk_contacts_guid &&
                   this.fk_sessions_guid == decisions.fk_sessions_guid &&
                   this.decision == decisions.decision &&
                   this.decisionother == decisions.decisionother &&
                   this.decisioncategory == decisions.decisioncategory;
        }

        public override int GetHashCode()
        {
            var hashCode = -2080173568;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_registrations_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_contacts_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_sessions_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.decision);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.decisionother);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.decisioncategory);
            return hashCode;
        }
    }
}
