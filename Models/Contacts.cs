using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Contacts
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string date { get; set; }
        public string duration { get; set; }
        public string type { get; set; }
        public string studytype { get; set; }
        public string fk_studyseries_guid { get; set; }
        public string studynumber { get; set; }
        public string fk_studytopics_guid { get; set; }
        public string studytopicother { get; set; }
        public string completed { get; set; }
        public string notes { get; set; }

        public static void Insert(Database database, HashSet<Contacts> set)
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
                    item.date,
                    item.duration,
                    item.type,
                    item.studytype,
                    item.fk_studyseries_guid,
                    item.studynumber,
                    item.fk_studytopics_guid,
                    item.studytopicother,
                    item.completed,
                    item.notes,
                });
            }
            database.Create(DB_Statements.INSERT_CONTACTS, parameters);
        }
        public static List<Contacts> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_CONTACTS);
            return BuildFromReader(reader);
        }

        private static List<Contacts> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Contacts>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Contacts()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_names_guid = row["fk_names_guid"] == DBNull.Value ? null : (string)row["fk_names_guid"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        date = row["date"] == DBNull.Value ? null : (string)row["date"],
                        duration = row["duration"] == DBNull.Value ? null : (string)row["duration"],
                        type = row["type"] == DBNull.Value ? null : (string)row["type"],
                        studytype = row["studytype"] == DBNull.Value ? null : (string)row["studytype"],
                        fk_studyseries_guid = row["fk_studyseries_guid"] == DBNull.Value ? null : (string)row["fk_studyseries_guid"],
                        studynumber = row["studynumber"] == DBNull.Value ? null : (string)row["studynumber"],
                        fk_studytopics_guid = row["fk_studytopics_guid"] == DBNull.Value ? null : (string)row["fk_studytopics_guid"],
                        studytopicother = row["studytopicother"] == DBNull.Value ? null : (string)row["studytopicother"],
                        completed = row["completed"] == DBNull.Value ? null : (string)row["completed"],
                        notes = row["notes"] == DBNull.Value ? null : (string)row["notes"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Contacts contacts &&
                   this.guid == contacts.guid &&
                   this.timestamp == contacts.timestamp &&
                   this.fk_churches_guid == contacts.fk_churches_guid &&
                   this.fk_names_guid == contacts.fk_names_guid &&
                   this.fk_workers_guid == contacts.fk_workers_guid &&
                   this.date == contacts.date &&
                   this.duration == contacts.duration &&
                   this.type == contacts.type &&
                   this.studytype == contacts.studytype &&
                   this.fk_studyseries_guid == contacts.fk_studyseries_guid &&
                   this.studynumber == contacts.studynumber &&
                   this.fk_studytopics_guid == contacts.fk_studytopics_guid &&
                   this.studytopicother == contacts.studytopicother &&
                   this.completed == contacts.completed &&
                   this.notes == contacts.notes;
        }

        public override int GetHashCode()
        {
            var hashCode = 1364224156;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_names_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.date);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.duration);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.studytype);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_studyseries_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.studynumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_studytopics_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.studytopicother);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.completed);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            return hashCode;
        }
    }
}
