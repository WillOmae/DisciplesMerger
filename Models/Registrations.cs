﻿using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Registrations
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_workers_guid { get; set; }
        public string ticketnumber { get; set; }
        public string advertising { get; set; }
        public string notes { get; set; }


        public static HashSet<Registrations> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_REGISTRATIONS);
            return BuildFromReader(reader);
        }

        private static HashSet<Registrations> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Registrations> result = new HashSet<Registrations>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Registrations()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_events_guid = (string)row["fk_events_guid"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        ticketnumber = (string)row["ticketnumber"],
                        advertising = (string)row["advertising"],
                        notes = (string)row["notes"],
                    });
                }
            }
            return result;
        }
    }
}
