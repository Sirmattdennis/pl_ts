using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "abcdefgh";
            string str2 = "123";

            Console.WriteLine(ZipStrings(str1, str2));
            Console.ReadLine();

        }

        public static string ZipStrings(string str1, string str2)
        {
            string rtn = "";
            char[] splitstr1 = str1.ToCharArray();
            char[] splitstr2 = str2.ToCharArray();
            int limit;

            if (str1.Length > str2.Length)
                limit = str1.Length;
            else
                limit = str2.Length;

            for (int i = 0; i <= limit; i++)
            {
                try { rtn += splitstr1[i]; }
                catch { }

                try { rtn += splitstr2[i]; }
                catch { }
            }

            return rtn;
        }
    }
}
