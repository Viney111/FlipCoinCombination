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
            int hhh_Counter = 0;
            int hht_Counter = 0;
            int htt_Counter = 0;
            int hth_Counter = 0;
            int ttt_Counter = 0;
            int thh_Counter = 0;
            int tht_Counter = 0;
            int tth_Counter = 0;
            IDictionary<int, string> tripletCombination = new Dictionary<int, string>();

            while (i1 <= FLIPCOINTIMES)
            {
                Random random1 = new Random();
                int flipCoin1 = random1.Next(0, 2);
                Random random2 = new Random();
                int flipCoin2 = random2.Next(0, 2);
                Random random3 = new Random();
                int flipCoin3 = random3.Next(0, 2);
                switch (flipCoin1, flipCoin2, flipCoin3)
                {
                    case (HEAD, HEAD, HEAD):
                        tripletCombination[i1] = "HHH ";
                        hhh_Counter++;
                        break;
                    case (HEAD, HEAD, TAIL):
                        tripletCombination[i1] = "HHT ";
                        hht_Counter++;
                        break;
                    case (HEAD, TAIL, TAIL):
                        tripletCombination[i1] = "HTT ";
                        htt_Counter++;
                        break;
                    case (HEAD, TAIL, HEAD):
                        tripletCombination[i1] = "HTH ";
                        hth_Counter++;
                        break;
                    case (TAIL, TAIL, TAIL):
                        tripletCombination[i1] = "TTT ";
                        ttt_Counter++;
                        break;
                    case (TAIL, HEAD, HEAD):
                        tripletCombination[i1] = "THH ";
                        thh_Counter++;
                        break;
                    case (TAIL, HEAD, TAIL):
                        tripletCombination[i1] = "THT ";
                        tht_Counter++;
                        break;
                    default:
                        tripletCombination[i1] = "TTH ";
                        tth_Counter++;
                        break;
                }
            i1++;
            }
            for (int i2 = 1; i2 <= tripletCombination.Count; i2++)
            {
                Console.Write(tripletCombination[i2]);
            }
            Console.WriteLine();
            Console.WriteLine($"Perentage of HHH Singlet is {(hhh_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of HHT Singlet is {(hht_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of HTT Singlet is {(htt_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of HTH Singlet is {(hth_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of TTT Singlet is {(ttt_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of THH Singlet is {(thh_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of THT Singlet is {(tht_Counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Perentage of TTH Singlet is {(tth_Counter * 100) / FLIPCOINTIMES}");

            Console.ReadLine();
            }

        }
    }
