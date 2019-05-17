﻿using System.Collections.Generic;

namespace DisciplesMerger.Models
{
    public class Relationships
    {
        public string guid { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string fk_names_guid { get; set; }
        public string fk_names_guid2 { get; set; }
        public string type { get; set; }
        public string sort { get; set; }


        public static List<Relationships> Read(Database database)
        {
            List<Dictionary<string, object>> reader = database.Read(DB_Statements.READ_RELATIONSHIPS);
            return BuildFromReader(reader);
        }

        private static List<Relationships> BuildFromReader(List<Dictionary<string, object>> rows)
        {
            List<Relationships> result = new List<Relationships>();
            if (rows != null)
            {
                foreach (Dictionary<string, object> row in rows)
                {
                    result.Add(new Relationships()
                    {
                        guid = (string)row["guid"],
                        timestamp = (string)row["timestamp"],
                        fk_churches_guid = (string)row["fk_churches_guid"],
                        fk_names_guid = (string)row["fk_names_guid"],
                        fk_names_guid2 = (string)row["fk_names_guid2"],
                        type = (string)row["type"],
                        sort = (string)row["sort"],
                    });
                }
            }
            return result;
        }
    }
}
