using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softheme
{
    class Program
    {
        /// <summary>
        /// The method calculates all possible combinations of coins to obtain a given value.
        /// </summary>
        /// <param name="coins">An array with coins for calculating combinations.</param>
        /// <param name="i">Index of coin. It determines which coin to use.</param>
        /// <param name="p">A sought value of a coin.</param>
        /// <returns>Number of possible combinations.</returns>
        static int Calc(int[] coins, int i, int p)
        {
            i++;
            if (i >= coins.Length || i < 0) // Checking for IndexOutOfRange
                return 0;
            if (p < 0) // If p is negative, then this combination doesn't fit.
                return 0;

            int res = 0;
            int buff = 0;

            res = Calc(coins, i, p); // Recursively go to the end of the array.

            buff = p - coins[i]; // Subtracting the value of the coin from the sought value. //200 - 100 = 100


            if (buff == 0) // If the buff is 0, the sum of the coins is 200.
                return 1;
            if (buff > 0)
                return res + Calc(coins, --i, buff);  //Next step is to calculate combinations for 100.
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