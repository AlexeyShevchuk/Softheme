using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softheme
{
    class Program
    {
        static int Calc(int[] coins, int i, int p)
        {
            i++;
            if (i >= coins.Length || i < 0)
                return 0;
            if (p < 0)
                return 0;

            int res = 0;
            int buff = 0;

            buff = p - coins[i];
            res = Calc(coins, i, p);

            if (buff == 0)
                return 1;
            if (buff > 0)
                return res + Calc(coins, --i, buff);
            return 0;
        }

        static void Main(string[] args)
        {
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            Console.WriteLine(Calc(coins, -1, 200));
            Console.ReadLine();
        }
    }
}

