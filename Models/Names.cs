using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Names
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
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
        public string baptismdate { get; set; }
        public string leadsource { get; set; }
        public string firstcontact { get; set; }
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
        public string birthdate { get; set; }
        public string referrer { get; set; }
        public string visitday { get; set; }
        public string visittime { get; set; }
        public string autoschedule { get; set; }
        public string notes { get; set; }
        public string confidential { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string permissions { get; set; }
        public string color { get; set; }


        public static List<Names> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_NAMES);
            return BuildFromReader(reader);
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
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        fk_workers_guid2 = (string)row["fk_workers_guid2"],
                        fk_smallgroups_guid = (string)row["fk_smallgroups_guid"],
                        type = (string)row["type"],
                        level = (string)row["level"],
                        status = (string)row["status"],
                        agegroup = (string)row["agegroup"],
                        marital = (string)row["marital"],
                        ethnicity = (string)row["ethnicity"],
                        ethnicityother = (string)row["ethnicityother"],
                        language = (string)row["language"],
                        languageother = (string)row["languageother"],
                        religion = (string)row["religion"],
                        religionother = (string)row["religionother"],
                        homechurch = (string)row["homechurch"],
                        attendingchurch = (string)row["attendingchurch"],
                        baptismdate = (string)row["baptismdate"],
                        leadsource = (string)row["leadsource"],
                        firstcontact = (string)row["firstcontact"],
                        title = (string)row["title"],
                        firstname = (string)row["firstname"],
                        lastname = (string)row["lastname"],
                        street = (string)row["street"],
                        unit = (string)row["unit"],
                        city = (string)row["city"],
                        state = (string)row["state"],
                        postal = (string)row["postal"],
                        country = (string)row["country"],
                        coordinates = (string)row["coordinates"],
                        phone1 = (string)row["phone1"],
                        phone1type = (string)row["phone1type"],
                        phone2 = (string)row["phone2"],
                        phone2type = (string)row["phone2type"],
                        email = (string)row["email"],
                        gender = (string)row["gender"],
                        birthdate = (string)row["birthdate"],
                        referrer = (string)row["referrer"],
                        visitday = (string)row["visitday"],
                        visittime = (string)row["visittime"],
                        autoschedule = (string)row["autoschedule"],
                        notes = (string)row["notes"],
                        confidential = (string)row["confidential"],
                        user = (string)row["user"],
                        password = (string)row["password"],
                        permissions = (string)row["permissions"],
                        color = (string)row["color"],
                    });
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Names names &&
                   this.guid == names.guid &&
                   this.timestamp == names.timestamp &&
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
            hashCode = hashCode * -1521134295 + this.timestamp.GetHashCode();
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
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.baptismdate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.leadsource);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.firstcontact);
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
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.birthdate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.referrer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.visitday);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.visittime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.autoschedule);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.notes);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.confidential);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.user);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.permissions);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.color);
            return hashCode;
        }
    }
}
