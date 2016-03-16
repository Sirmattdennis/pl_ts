using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcDir = "../../files";
            string destFileName = AppDomain.CurrentDomain.BaseDirectory + "../../../results.txt";
            string searchTerm;

            Console.WriteLine("(Try dictum or et for easy example results)");
            Console.Write("Enter search term: ");
            searchTerm = Console.ReadLine();

            DoThings(srcDir, destFileName, searchTerm);

            Console.ReadLine();
        }

        public static void DoThings(string srcdir, string destfilename, string searchterm)
        {
            DirectoryInfo di = new DirectoryInfo(srcdir);
            int filesProcessed = 0;
            int searchTermCount = 0;
            int searchTermLineCount = 0;
            string resultString = "";
            
            foreach (FileInfo file in di.EnumerateFiles())
            {
                StreamReader sr = new StreamReader(file.FullName);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, searchterm))
                    {
                        searchTermCount += Regex.Matches(line, searchterm).Count;
                        ++searchTermLineCount;
                        resultString += line + Environment.NewLine;
                    }
                }

                ++filesProcessed;
            }

            Console.WriteLine("Files processed: " + filesProcessed);
            Console.WriteLine("Lines containing search string: " + searchTermLineCount);
            Console.WriteLine("Total times search string was found: " + searchTermCount);
            Console.WriteLine("(results.txt located in the solution root folder, \"2-4c\")");
            
            File.WriteAllText(destfilename, resultString);
        }
    }
}
