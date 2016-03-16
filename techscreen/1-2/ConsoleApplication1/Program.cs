using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string bigWord = "redbluegreenredorangepurpleredredbluegreenbluepurpleredblue";
            string findWord = "red";

            Console.WriteLine(GetResultCount(bigWord, findWord));
            Console.ReadLine();

        }

        public static int? GetResultCount(string bigword, string findword)
        {
            int findCount = Regex.Matches(bigword, findword).Count;

            return findCount;
        }
    }
}
