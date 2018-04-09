using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutused
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Console.WriteLine("Sisestage nimesi, lõpetamiseks kirjutage \"-1\"");

            while (true)
            {
                Console.Write("Sisend >");
                string input = Console.ReadLine();

                if (input == "-1")
                    break;

                else
                {
                    input = char.ToUpper(input[0]) + input.Substring(1);
                    Names.Add(input);
                }
                
            }
            Console.WriteLine($"Sisestatud nimed: {string.Join(", ", Names)}");

            Console.ReadKey();

        }
    }
}
