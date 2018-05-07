using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            Console.WriteLine("--------------------------------------------------------------");

            double total = 0; //deklareerin väljaspool tsüklit, et saaks kasutada seda välajaspool while

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();

                double value = double.Parse(input);

                if (input == "-1")
                    break;

                total = total + value;
            }
            Console.WriteLine("--------------------------------------------------------------");
            double gratuity = total * 0.15;

            Console.WriteLine($"Subtotal: {total}€");
            Console.WriteLine($"15% Gratuity: {gratuity}€");
            Console.WriteLine($"Total: {total - gratuity}€");


            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }

    }
}
