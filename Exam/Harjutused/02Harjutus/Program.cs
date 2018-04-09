using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Harjutus
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] Names = new string[] {
              //  "Kaur","Mattias","Kristel", "Helen","Trevor","Kristjan", "Kelli", "Kevin","Maarika","Laura"};
           // string[] names = new string[]
            {
              //  "kaur","mattias","kristel", "helen","trevor","kristjan", "kelli", "kevin","maarika","laura"
            };
            
            Console.WriteLine("Sisestage sõna, lause või hoopiski kümme lauset. Lõpetamiseks sisestahe -1");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Sisend > ");
                string Text = Console.ReadLine();
                string[] splitted = Text.Split(' ');

                if (Text == "-1")
                    break;

                foreach (var Word in splitted)
                {

                    if (Word == "kaur")
                    { Console.Write(" Kaur "); continue; }

                    if (Word == "mattias")
                    { Console.Write(" Mattias "); continue; }

                    if (Word == "kristel")
                    { Console.Write(" Kristel "); continue; }

                    if (Word == "helen")
                    { Console.Write(" Helen "); continue; }

                    if (Word == "trevor")
                    { Console.Write(" Trevor "); continue; }

                    if (Word == "kristjan")
                    { Console.Write(" Kristjan "); continue; }

                    if (Word == "kelli")
                    { Console.Write(" Kelli "); continue; }

                    if (Word == "kevin")
                    { Console.Write(" Kevin "); continue; }

                    if (Word == "maarika")
                    { Console.Write(" Maarika "); continue; }

                    if (Word == "laura")
                    { Console.Write(" Laura "); continue; }

                    else
                        Console.Write($" {Word} ");

                }
            }
            
            Console.ReadKey();
        }
    }
}
