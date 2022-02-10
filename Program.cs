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
            const int TAIL = 0;
            const int FLIPCOINTIMES = 20;

            //VARIABLES
            int i1 = 1;
            int ht_Counter = 0;
            int th_Counter = 0;
            int hh_Counter = 0;
            int tt_Counter = 0;

            IDictionary<int, string> doubletCombination = new Dictionary<int, string>();

            while (i1 <= FLIPCOINTIMES)
            {
                Random random1 = new Random();
                int flipCoin1 = random1.Next(0, 2);
                Random random2 = new Random();
                int flipCoin2 = random2.Next(0, 2);
                switch (flipCoin1, flipCoin2)
                {
                    case (HEAD, TAIL):
                        doubletCombination[i1] = "HT ";
                        ht_Counter++;
                        break;
                    case (TAIL, HEAD):
                        doubletCombination[i1] = "TH ";
                        th_Counter++;
                        break;
                    case (HEAD, HEAD):
                        doubletCombination[i1] = "HH ";
                        hh_Counter++;
                        break;
                    default:
                        doubletCombination[i1] = "TT ";
                        tt_Counter++;
                        break;
                }
            i1++;
            }
            for (int i2 = 1; i2 <= doubletCombination.Count; i2++)
            {
                Console.Write(doubletCombination[i2]);
            }
            Console.WriteLine();
            Console.WriteLine($"Perentage of HH Singlet is {(hh_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of TT Singlet is {(tt_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of HT Singlet is {(ht_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of TH Singlet is {(th_Counter * 100) / FLIPCOINTIMES}");


            Console.ReadLine();
            }

        }
    }
