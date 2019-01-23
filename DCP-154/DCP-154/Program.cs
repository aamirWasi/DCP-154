using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_154
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                long num1 = long.Parse(space[0]);
                long sNum = (num1 * (num1 + 1) * (2 * num1 + 1)) / 6;
                long sNumWhole = (num1 * (num1 + 1)) / 2;
                long sNumSqr = sNumWhole * sNumWhole;
                long result = sNumSqr - sNum;
                Console.WriteLine($"{result}");
            }
        }
    }
}
