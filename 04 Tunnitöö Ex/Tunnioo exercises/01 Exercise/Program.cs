using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Kuidas Teil läheb? ");
            Console.Write("");
            string input = Console.ReadLine();

            Console.Write($"\nMiks Teil läheb {input} ? ");
            string input2 = Console.ReadLine();

            int number = rnd.Next(2);

            switch (number)
            {
                case 0:
                    {
                        Console.WriteLine("Huvitav");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Tore!");
                        break;
                    }
            }
            Console.ReadLine();



        }
    }
}
