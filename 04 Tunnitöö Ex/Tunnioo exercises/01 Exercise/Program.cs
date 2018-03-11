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
            //Asks about your day
       
            Random rnd = new Random();

            Console.Write("Kuidas Teil läheb? ");
            string input = Console.ReadLine();

            Console.Write($"\nMiks Teil läheb {input} ? ");
            string input2 = Console.ReadLine();

            int number = rnd.Next(2);

            switch (number)
            {
                case 0:
                    {
                        Console.WriteLine("\n Huvitav");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("\n Tore!");
                        break;
                    }
                    
            }
            Console.ReadLine();



        }
    }
}
