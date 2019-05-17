﻿using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Filters
    {
        public string guid { get; set; }
        public long timestamp { get; set; }
        public string fk_workers_guid { get; set; }
        public string name { get; set; }
        public string andor { get; set; }
        public string categories { get; set; }
        public string columns { get; set; }
        public string operators { get; set; }
        public string queries { get; set; }


        public static HashSet<Filters> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_FILTERS);
            return BuildFromReader(reader);
        }

        private static HashSet<Filters> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            HashSet<Filters> result = new HashSet<Filters>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Filters()
                    {
                        guid = (string)row["guid"],
                        timestamp = (long)row["timestamp"],
                        fk_workers_guid = (string)row["fk_workers_guid"],
                        name = (string)row["name"],
                        andor = (string)row["andor"],
                        categories = (string)row["categories"],
                        columns = (string)row["columns"],
                        operators = (string)row["operators"],
                        queries = (string)row["queries"],
                    });
                }
            }
            return result;
        }
    }
}
