using System;
using System.IO;

namespace DisciplesMerger
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var files = GetFiles();
            if (files.Length == 0)
            {
                Console.WriteLine("No files found. Program will exit.");
                Console.ReadKey();
                return;
            }
            switch (GetUserConsent())
            {
                case true:
                    string[] filenames = new string[files.Length];
                    for (int i = 0; i < files.Length; i++)
                    {
                        filenames[i] = files[i].FullName;
                    }
                    var disciplesMerger = new DisciplesMerger(filenames);
                    disciplesMerger.Merge();
                    Console.WriteLine("Done");
                    break;
                case false:
                    break;
            }
            Console.ReadKey();
        }
        private static FileInfo[] GetFiles()
        {
            var launchPath = Environment.CurrentDirectory;
            var databasesPath = Path.Combine(launchPath, "Databases");
            var databaseFolder = Directory.CreateDirectory(databasesPath);
            var files = databaseFolder.GetFiles();

            Console.WriteLine("Enumerating files in " + databasesPath);
            Console.WriteLine("Found {0} files as listed below:", files.Length);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine("{0}. " + files[i], i + 1);
            }
            return files;
        }
        private static bool GetUserConsent()
        {
            string response;
            do
            {
                Console.WriteLine("Are they all databases? Yes(y) to proceed, No (n) to cancel or exit.");
                var input = Console.ReadLine();
                response = input.ToLower().Contains("y") ? "yes" : input.ToLower().Contains("n") ? "exit" : "invalid";
            } while (!response.Equals("yes") && !response.Equals("exit"));
            return response.Equals("yes") ? true : false;
        }
    }
}
