using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static int Calc(ref int[] a, int i, int p)
        {
            int res = 0;
            i++;
            if (i >= a.Length || i < 0)
            {
                return 0;
            }
            if (p < 0)
                return 0;
            int buff = p - a[i];
            res = Calc(ref a, i, p);
            if (buff == 0)
            {
                return 1;
            }
            if (buff > 0)
            {
                return res + Calc(ref a, --i, buff);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            Console.WriteLine(Calc(ref coins, -1, 200));
            Console.ReadLine();
        }
    }
}

