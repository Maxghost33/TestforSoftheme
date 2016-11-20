using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestCaseTriagle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int j = 0;
            string[] p = File.ReadAllLines(@"Triagle.txt", System.Text.Encoding.Default);
            //{ str0, str1, str2, str3, str4, str5, str6 };
            sum = int.Parse(p[0].Split(' ')[0]);
            for (int i = 1; i < p.Length; i++)
            {
                if (int.Parse(p[i].Split(' ')[j]) > int.Parse(p[i].Split(' ')[j + 1]))
                {
                    sum += int.Parse(p[i].Split(' ')[j]);
                }
                else
                {
                    sum += int.Parse(p[i].Split(' ')[j + 1]);
                    j += 1;
                }
            }
            Console.WriteLine("Amount diagonally =>" + " " + sum);
            Console.ReadKey();
        }
    }
}
