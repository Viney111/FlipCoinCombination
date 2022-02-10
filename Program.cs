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

            Random random = new Random();
            int flipCoin = random.Next(0,2);
            if (flipCoin == HEAD)
            {
                Console.WriteLine("HEAD");
            }
            else
            {
                Console.WriteLine("TAIL");
            }

            Console.ReadLine();
        }

    }
}
