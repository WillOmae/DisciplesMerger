using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Names
    {
        public string guid { get; set; }
        public long? timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string fk_workers_guid2 { get; set; }
        public string fk_smallgroups_guid { get; set; }
        public string type { get; set; }
        public string level { get; set; }
        public string status { get; set; }
        public string agegroup { get; set; }
        public string marital { get; set; }
        public string ethnicity { get; set; }
        public string ethnicityother { get; set; }
        public string language { get; set; }
        public string languageother { get; set; }
        public string religion { get; set; }
        public string religionother { get; set; }
        public string homechurch { get; set; }
        public string attendingchurch { get; set; }
        public long? baptismdate { get; set; }
        public string leadsource { get; set; }
        public long? firstcontact { get; set; }
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string street { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string coordinates { get; set; }
        public string phone1 { get; set; }
        public string phone1type { get; set; }
        public string phone2 { get; set; }
        public string phone2type { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public long? birthdate { get; set; }
        public string referrer { get; set; }
        public string visitday { get; set; }
        public double? visittime { get; set; }
        public string autoschedule { get; set; }
        public string notes { get; set; }
        public string confidential { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string permissions { get; set; }
        public long? color { get; set; }
        public static void Insert(Database database, HashSet<Names> set)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in set)
            {
                parameters.Add(new List<object>()
                {
                    item.guid,
                   item.timestamp,
                   item.fk_churches_guid,
                   item.fk_workers_guid,
                   item.fk_workers_guid2,
                   item.fk_smallgroups_guid,
                   item.type,
                   item.level,
                   item.status,
                   item.agegroup,
                   item.marital,
                   item.ethnicity,
                   item.ethnicityother,
                   item.language,
                   item.languageother,
                   item.religion,
                   item.religionother,
                   item.homechurch,
                   item.attendingchurch,
                   item.baptismdate,
                   item.leadsource,
                   item.firstcontact,
                   item.title,
                   item.firstname,
                   item.lastname,
                   item.street,
                   item.unit,
                   item.city,
                   item.state,
                   item.postal,
                   item.country,
                   item.coordinates,
                   item.phone1,
                   item.phone1type,
                   item.phone2,
                   item.phone2type,
                   item.email,
                   item.gender,
                   item.birthdate,
                   item.referrer,
                   item.visitday,
                   item.visittime,
                   item.autoschedule,
                   item.notes,
                   item.confidential,
                   item.user,
                   item.password,
                   item.permissions,
                   item.color,
                });
            }
            database.Create(DB_Statements.INSERT_NAMES, parameters);
        }

        public static List<Names> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_NAMES);
            return BuildFromReader(reader);
        }

        public static void Update(Database database, List<Names> names)
        {
            List<List<object>> parameters = new List<List<object>>();
            foreach (var item in names)
            {
                parameters.Add(new List<object>()
                {
                    item.firstname,
                    item.lastname,
                    item.guid,
                });
            }
            database.Create(DB_Statements.UPDATE_NAMES, parameters);
        }

        private static List<Names> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            var result = new List<Names>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Names()
                    {
                        guid = row["guid"] == DBNull.Value ? null : (string)row["guid"],
                        timestamp = row["timestamp"] == DBNull.Value ? null : (long?)row["timestamp"],
                        fk_churches_guid = row["fk_churches_guid"] == DBNull.Value ? null : (string)row["fk_churches_guid"],
                        fk_workers_guid = row["fk_workers_guid"] == DBNull.Value ? null : (string)row["fk_workers_guid"],
                        fk_workers_guid2 = row["fk_workers_guid2"] == DBNull.Value ? null : (string)row["fk_workers_guid2"],
                        fk_smallgroups_guid = row["fk_smallgroups_guid"] == DBNull.Value ? null : (string)row["fk_smallgroups_guid"],
                        type = row["type"] == DBNull.Value ? null : (string)row["type"],
                        level = row["level"] == DBNull.Value ? null : (string)row["level"],
                        status = row["status"] == DBNull.Value ? null : (string)row["status"],
                        agegroup = row["agegroup"] == DBNull.Value ? null : (string)row["agegroup"],
                        marital = row["marital"] == DBNull.Value ? null : (string)row["marital"],
                        ethnicity = row["ethnicity"] == DBNull.Value ? null : (string)row["ethnicity"],
                        ethnicityother = row["ethnicityother"] == DBNull.Value ? null : (string)row["ethnicityother"],
                        language = row["language"] == DBNull.Value ? null : (string)row["language"],
                        languageother = row["languageother"] == DBNull.Value ? null : (string)row["languageother"],
                        religion = row["religion"] == DBNull.Value ? null : (string)row["religion"],
                        religionother = row["religionother"] == DBNull.Value ? null : (string)row["religionother"],
                        homechurch = row["homechurch"] == DBNull.Value ? null : (string)row["homechurch"],
                        attendingchurch = row["attendingchurch"] == DBNull.Value ? null : (string)row["attendingchurch"],
                        baptismdate = row["baptismdate"] == DBNull.Value ? null : (long?)row["baptismdate"],
                        leadsource = row["leadsource"] == DBNull.Value ? null : (string)row["leadsource"],
                        firstcontact = row["firstcontact"] == DBNull.Value ? null : (long?)row["firstcontact"],
                        title = row["title"] == DBNull.Value ? null : (string)row["title"],
                        firstname = row["firstname"] == DBNull.Value ? null : (string)row["firstname"],
                        lastname = row["lastname"] == DBNull.Value ? null : (string)row["lastname"],
                        street = row["street"] == DBNull.Value ? null : (string)row["street"],
                        unit = row["unit"] == DBNull.Value ? null : (string)row["unit"],
                        city = row["city"] == DBNull.Value ? null : (string)row["city"],
                        state = row["state"] == DBNull.Value ? null : (string)row["state"],
                        postal = row["postal"] == DBNull.Value ? null : (string)row["postal"],
                        country = row["country"] == DBNull.Value ? null : (string)row["country"],
                        coordinates = row["coordinates"] == DBNull.Value ? null : (string)row["coordinates"],
                        phone1 = row["phone1"] == DBNull.Value ? null : (string)row["phone1"],
                        phone1type = row["phone1type"] == DBNull.Value ? null : (string)row["phone1type"],
                        phone2 = row["phone2"] == DBNull.Value ? null : (string)row["phone2"],
                        phone2type = row["phone2type"] == DBNull.Value ? null : (string)row["phone2type"],
                        email = row["email"] == DBNull.Value ? null : (string)row["email"],
                        gender = row["gender"] == DBNull.Value ? null : (string)row["gender"],
                        birthdate = row["birthdate"] == DBNull.Value ? null : (long?)row["birthdate"],
                        referrer = row["referrer"] == DBNull.Value ? null : (string)row["referrer"],
                        visitday = row["visitday"] == DBNull.Value ? null : (string)row["visitday"],
                        //visittime = row["visittime"] == DBNull.Value ? null : (double?)row["visittime"],
                        autoschedule = row["autoschedule"] == DBNull.Value ? null : (string)row["autoschedule"],
                        notes = row["notes"] == DBNull.Value ? null : (string)row["notes"],
                        confidential = row["confidential"] == DBNull.Value ? null : (string)row["confidential"],
                        user = row["user"] == DBNull.Value ? null : (string)row["user"],
                        password = row["password"] == DBNull.Value ? null : (string)row["password"],
                        permissions = row["permissions"] == DBNull.Value ? null : (string)row["permissions"],
                        color = row["color"] == DBNull.Value ? null : (long?)row["color"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Names names &&
                   this.guid == names.guid &&
                   //this.timestamp == names.timestamp &&
                   this.fk_churches_guid == names.fk_churches_guid &&
                   this.fk_workers_guid == names.fk_workers_guid &&
                   this.fk_workers_guid2 == names.fk_workers_guid2 &&
                   this.fk_smallgroups_guid == names.fk_smallgroups_guid &&
                   this.type == names.type &&
                   this.level == names.level &&
                   this.status == names.status &&
                   this.agegroup == names.agegroup &&
                   this.marital == names.marital &&
                   this.ethnicity == names.ethnicity &&
                   this.ethnicityother == names.ethnicityother &&
                   this.language == names.language &&
                   this.languageother == names.languageother &&
                   this.religion == names.religion &&
                   this.religionother == names.religionother &&
                   this.homechurch == names.homechurch &&
                   this.attendingchurch == names.attendingchurch &&
                   this.baptismdate == names.baptismdate &&
                   this.leadsource == names.leadsource &&
                   this.firstcontact == names.firstcontact &&
                   this.title == names.title &&
                   this.firstname == names.firstname &&
                   this.lastname == names.lastname &&
                   this.street == names.street &&
                   this.unit == names.unit &&
                   this.city == names.city &&
                   this.state == names.state &&
                   this.postal == names.postal &&
                   this.country == names.country &&
                   this.coordinates == names.coordinates &&
                   this.phone1 == names.phone1 &&
                   this.phone1type == names.phone1type &&
                   this.phone2 == names.phone2 &&
                   this.phone2type == names.phone2type &&
                   this.email == names.email &&
                   this.gender == names.gender &&
                   this.birthdate == names.birthdate &&
                   this.referrer == names.referrer &&
                   this.visitday == names.visitday &&
                   this.visittime == names.visittime &&
                   this.autoschedule == names.autoschedule &&
                   this.notes == names.notes &&
                   this.confidential == names.confidential &&
                   this.user == names.user &&
                   this.password == names.password &&
                   this.permissions == names.permissions &&
                   this.color == names.color;
        }

        public override int GetHashCode()
        {
            var hashCode = -1582930829;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.guid);
            //hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_churches_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_workers_guid2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.fk_smallgroups_guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.level);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.agegroup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.marital);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ethnicity);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ethnicityother);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.language);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.languageother);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.religion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.religionother);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.homechurch);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.attendingchurch);
            hashCode = hashCode * -1521134295 + this.baptismdate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.leadsource);
            hashCode = hashCode * -1521134295 + this.firstcontact.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.firstname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.lastname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.unit);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.postal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.coordinates);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.phone1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.phone1type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.phone2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.phone2type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.gender);
            hashCode = hashCode * -1521134295 + this.birthdate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.referrer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.visitday);
            hashCode = hashCode * -1521134295 + this.visittime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.autoschedule);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.confidential);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.user);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.permissions);
            hashCode = hashCode * -1521134295 + this.color.GetHashCode();
            return hashCode;
        }
    }
}
