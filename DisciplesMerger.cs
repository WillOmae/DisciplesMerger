using DisciplesMerger.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DisciplesMerger
{
    partial class Program
    {
        public class DisciplesMerger
        {
            private Database[] databases;
            public DisciplesMerger(string[] filenames)
            {
                databases = new Database[filenames.Length];
                for (int i = 0; i < filenames.Length; i++)
                {
                    databases[i] = new Database(filenames[i]);
                }
            }
            public void Merge()
            {
                MergeAttendance();
            }
            private void MergeAttendance()
            {
                HashSet<Attendance> attendances = new HashSet<Attendance>();
                for (int i = 0; i < databases.Length; i++)
                {
                    attendances.Union(Attendance.Read(this.databases[i]));
                }
                Console.WriteLine("count. " + attendances.Count);
            }
        }
    }
}
