using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Names
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
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
            List<Names> result = new List<Names>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Names()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
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
    }
}
