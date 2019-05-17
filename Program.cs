using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplesMerger
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var NEWLINE = Environment.NewLine;
            var DOUBLENEWLINE = NEWLINE + NEWLINE;
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
            string response = string.Empty;
            do
            {
                Console.WriteLine("Are they all databases? Yes(y) to proceed, No (n) to cancel.");
                var input = Console.ReadLine();
                response = input.ToLower().Contains('y') ? "yes" : input.ToLower().Contains('n') ? "exit" : "invalid";
            } while (!response.Equals("yes") && !response.Equals("exit"));

            switch (response)
            {
                case "yes":
                    string[] filenames = new string[files.Length];
                    for (int i = 0; i < files.Length; i++)
                    {
                        filenames[i] = files[i].FullName;
                    }
                    var disciplesMerger = new DisciplesMerger(filenames);
                    disciplesMerger.Merge();
                    break;
                case "exit":
                    break;
            }
            Console.ReadKey();
        }
    }
}
