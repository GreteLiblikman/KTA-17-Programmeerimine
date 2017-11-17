using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kartul";
            int a1 = 2;
            int a2 = 4;
            int input = GetUserInput();

            Console.WriteLine($"Hello {input, value}");

            PrintName(name);
            CalculateThis(a1, a2);


            Console.ReadLine();
        }
        static int GetUserInput()
        {
            bool success = false;

            while (success)
            {
                string input = Console.ReadLine();
                //int value = int.Parse(input);
                int value = 0;
                ////int.TryParse(input, out value);
                success = int.TryParse(input, out value);
            }
            return value;
        }


        public static void PrintName(string name)
        {

            Console.WriteLine("hello " + (name));
        }

        static void CalculateThis(int a1, int a2)

        {
            Console.Write($"Summa: {a1 * a2}");
        }
    }
}
