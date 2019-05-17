﻿using System;
using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Attendance
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_events_guid { get; set; }
        public string fk_sessions_guid { get; set; }

        public static HashSet<Attendance> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_ATTENDANCE);
            return BuildFromReader(reader);
        }

        private static HashSet<Attendance> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Attendance> result = new HashSet<Attendance>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Attendance()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_events_guid = (string)row["fk_events_guid"],
                        fk_sessions_guid = (string)row["fk_sessions_guid"]
                    });
                }
            }
            return result;
        }
    }
}
