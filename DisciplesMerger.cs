using DisciplesMerger.Models;
using System.Collections.Generic;

namespace DisciplesMerger
{
    partial class Program
    {
        public class DisciplesMerger
        {
            private Database[] databases;
            private Database proper;
            public DisciplesMerger(string[] filenames)
            {
                databases = new Database[filenames.Length];
                for (int i = 0; i < filenames.Length; i++)
                {
                    databases[i] = new Database(filenames[i]);
                }
                // The first database is the proper database
                // to which all data is to be written.
                proper = databases[0];
            }
            public void Merge()
            {
                MergeAttendance();
                MergeContacts();
                MergeDecisions();
                MergeEvents();
                MergeFilters();
                MergeGroups();
                MergeInterests();
                MergeJournalentries();
                MergeMetadata();
                MergeNames();
                MergeRegistrations();
                MergeRelationships();
                MergeSessions();
                MergeSmallgroups();
                MergeSynclogs();
                TrimNames();
            }
            private void MergeAttendance()
            {
                var allData = new List<Attendance>();
                var dataInProper = new List<Attendance>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Attendance.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Attendance>(allData), new HashSet<Attendance>(dataInProper));
                Attendance.Insert(this.proper, toWrite);
            }
            private void MergeContacts()
            {
                var allData = new List<Contacts>();
                var dataInProper = new List<Contacts>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Contacts.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Contacts>(allData), new HashSet<Contacts>(dataInProper));
                Contacts.Insert(this.proper, toWrite);
            }
            private void MergeDecisions()
            {
                var allData = new List<Decisions>();
                var dataInProper = new List<Decisions>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Decisions.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Decisions>(allData), new HashSet<Decisions>(dataInProper));
                Decisions.Insert(this.proper, toWrite);
            }
            private void MergeEvents()
            {
                var allData = new List<Events>();
                var dataInProper = new List<Events>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Events.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Events>(allData), new HashSet<Events>(dataInProper));
                Events.Insert(this.proper, toWrite);
            }
            private void MergeFilters()
            {
                var allData = new List<Filters>();
                var dataInProper = new List<Filters>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Filters.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Filters>(allData), new HashSet<Filters>(dataInProper));
                Filters.Insert(this.proper, toWrite);
            }
            private void MergeGroups()
            {
                var allData = new List<Groups>();
                var dataInProper = new List<Groups>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Groups.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Groups>(allData), new HashSet<Groups>(dataInProper));
                Groups.Insert(this.proper, toWrite);
            }
            private void MergeInterests()
            {
                var allData = new List<Interests>();
                var dataInProper = new List<Interests>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Interests.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Interests>(allData), new HashSet<Interests>(dataInProper));
                Interests.Insert(this.proper, toWrite);
            }
            private void MergeJournalentries()
            {
                var allData = new List<Journalentries>();
                var dataInProper = new List<Journalentries>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Journalentries.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Journalentries>(allData), new HashSet<Journalentries>(dataInProper));
                Journalentries.Insert(this.proper, toWrite);
            }
            private void MergeMetadata()
            {
                var allData = new List<Metadata>();
                var dataInProper = new List<Metadata>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Metadata.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Metadata>(allData), new HashSet<Metadata>(dataInProper));
                Metadata.Insert(this.proper, toWrite);
            }
            private void MergeNames()
            {
                var allData = new List<Names>();
                var dataInProper = new List<Names>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Names.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Names>(allData), new HashSet<Names>(dataInProper));
                Names.Insert(this.proper, toWrite);
            }
            private void MergeRegistrations()
            {
                var allData = new List<Registrations>();
                var dataInProper = new List<Registrations>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Registrations.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Registrations>(allData), new HashSet<Registrations>(dataInProper));
                Registrations.Insert(this.proper, toWrite);
            }
            private void MergeRelationships()
            {
                var allData = new List<Relationships>();
                var dataInProper = new List<Relationships>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Relationships.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Relationships>(allData), new HashSet<Relationships>(dataInProper));
                Relationships.Insert(this.proper, toWrite);
            }
            private void MergeSessions()
            {
                var allData = new List<Sessions>();
                var dataInProper = new List<Sessions>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Sessions.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Sessions>(allData), new HashSet<Sessions>(dataInProper));
                Sessions.Insert(this.proper, toWrite);
            }
            private void MergeSmallgroups()
            {
                var allData = new List<Smallgroups>();
                var dataInProper = new List<Smallgroups>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Smallgroups.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Smallgroups>(allData), new HashSet<Smallgroups>(dataInProper));
                Smallgroups.Insert(this.proper, toWrite);
            }
            private void MergeSynclogs()
            {
                var allData = new List<Synclogs>();
                var dataInProper = new List<Synclogs>();
                for (int i = 0; i < databases.Length; i++)
                {
                    var l = Synclogs.Read(this.databases[i]);
                    if (i == 0)
                    {
                        dataInProper = l;
                    }
                    allData.AddRange(l);
                }
                var toWrite = this.SubtractHashSet(new HashSet<Synclogs>(allData), new HashSet<Synclogs>(dataInProper));
                Synclogs.Insert(this.proper, toWrite);
            }
            private HashSet<T> SubtractHashSet<T>(HashSet<T> allData, HashSet<T> dataInProper)
            {
                allData.ExceptWith(dataInProper);
                return allData;
            }

            private void TrimNames()
            {
                var names = Names.Read(proper);
                List<Names> trimmed = new List<Names>(names.Capacity);
                foreach (var name in names)
                {
                    if ((name.firstname.Length > 0 && (name.firstname[0] == ' ' || name.firstname[name.firstname.Length - 1] == ' ')) || (name.lastname.Length > 0 && (name.lastname[0] == ' ' || name.lastname[name.lastname.Length - 1] == ' ')))
                    {
                        name.firstname = name.firstname.Trim();
                        name.lastname = name.lastname.Trim();
                        trimmed.Add(name);
                    }
                }
                Names.Update(proper, trimmed);
            }
        }
    }
}
