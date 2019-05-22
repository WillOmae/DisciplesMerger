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
                // The first database is the proper database
                // to which all data is to be written.
                // The other databases start from index 1...
                databases = new Database[filenames.Length];
                proper = databases[0];
                for (int i = 1; i < filenames.Length; i++)
                {
                    databases[i] = new Database(filenames[i]);
                }
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
            }
            private void MergeAttendance()
            {
                var list = new List<Attendance>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Attendance.Read(this.databases[i]));
                }
                Attendance.Insert(this.proper, new HashSet<Attendance>(list));
            }
            private void MergeContacts()
            {
                var list = new List<Contacts>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Contacts.Read(this.databases[i]));
                }
                Contacts.Insert(this.proper, new HashSet<Contacts>(list));
            }
            private void MergeDecisions()
            {
                var list = new List<Decisions>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Decisions.Read(this.databases[i]));
                }
                Decisions.Insert(this.proper, new HashSet<Decisions>(list));
            }
            private void MergeEvents()
            {
                var list = new List<Events>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Events.Read(this.databases[i]));
                }
                Events.Insert(this.proper, new HashSet<Events>(list));
            }
            private void MergeFilters()
            {
                var list = new List<Filters>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Filters.Read(this.databases[i]));
                }
                Filters.Insert(this.proper, new HashSet<Filters>(list));
            }
            private void MergeGroups()
            {
                var list = new List<Groups>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Groups.Read(this.databases[i]));
                }
                Groups.Insert(this.proper, new HashSet<Groups>(list));
            }
            private void MergeInterests()
            {
                var list = new List<Interests>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Interests.Read(this.databases[i]));
                }
                Interests.Insert(this.proper, new HashSet<Interests>(list));
            }
            private void MergeJournalentries()
            {
                var list = new List<Journalentries>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Journalentries.Read(this.databases[i]));
                }
                Journalentries.Insert(this.proper, new HashSet<Journalentries>(list));
            }
            private void MergeMetadata()
            {
                var list = new List<Metadata>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Metadata.Read(this.databases[i]));
                }
                Metadata.Insert(this.proper, new HashSet<Metadata>(list));
            }
            private void MergeNames()
            {
                var list = new List<Names>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Names.Read(this.databases[i]));
                }
                Names.Insert(this.proper, new HashSet<Names>(list));
            }
            private void MergeRegistrations()
            {
                var list = new List<Registrations>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Registrations.Read(this.databases[i]));
                }
                Registrations.Insert(this.proper, new HashSet<Registrations>(list));
            }
            private void MergeRelationships()
            {
                var list = new List<Relationships>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Relationships.Read(this.databases[i]));
                }
                Relationships.Insert(this.proper, new HashSet<Relationships>(list));
            }
            private void MergeSessions()
            {
                var list = new List<Sessions>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Sessions.Read(this.databases[i]));
                }
                Sessions.Insert(this.proper, new HashSet<Sessions>(list));
            }
            private void MergeSmallgroups()
            {
                var list = new List<Smallgroups>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Smallgroups.Read(this.databases[i]));
                }
                Smallgroups.Insert(this.proper, new HashSet<Smallgroups>(list));
            }
            private void MergeSynclogs()
            {
                var list = new List<Synclogs>();
                for (int i = 0; i < databases.Length; i++)
                {
                    list.AddRange(Synclogs.Read(this.databases[i]));
                }
                Synclogs.Insert(this.proper, new HashSet<Synclogs>(list));
            }
        }
    }
}
