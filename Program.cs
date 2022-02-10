using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class Combination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Flip Coin Combination Program");
            //CONSTATNTS
            const int HEAD = 1;
            const int FLIPCOINTIMES = 20;

            //VARIABLES
            int i1 = 1;
            int headCounter = 0;
            int tailCounter = 0;
            IDictionary<int, string> singletCombination = new Dictionary<int, string>();

            while ( i1 <= FLIPCOINTIMES)
            {
                Random random = new Random();
                int flipCoin = random.Next(0, 2);
                if (flipCoin == HEAD)
                {
                    //Console.WriteLine("HEAD");
                    singletCombination[i1] = "H ";
                    headCounter++;
                }
                else
                {
                    //Console.WriteLine("TAIL");
                    singletCombination[i1] = "T ";
                    tailCounter++;
                }
            i1++;
            }
            for (int i2 = 1; i2 <= singletCombination.Count; i2++)
            {
                Console.Write(singletCombination[i2]);
            }
            Console.WriteLine();
            Console.WriteLine($"Perentage of Head Singlet is {(headCounter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of Tail Singlet is {(tailCounter * 100) / FLIPCOINTIMES}");
            

            Console.ReadLine();
        }

    }
}
