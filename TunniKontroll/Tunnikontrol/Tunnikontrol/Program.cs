using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            Console.WriteLine("--------------------------------------------------------------");

            
            
                Console.Write("Enter price op food item[-1 to quit]: ");
                string input = Console.ReadLine();

                int hind = int.Parse(input);


            while (true)
            {
                int vastus =  hind{6};

                if (hind == -1)

                {
                    Console.WriteLine("");
                    break;
                }

                Console.WriteLine("--------------------------------------------------------------");

                }
            int percent = 15;
            var finalamount = vastus;
            finalamount = System.Math.Round(finalamount, 6);
            int percent = 15;

                                                
            Console.WriteLine($"Subtotal:" +vastus);
            Console.WriteLine("15% Gratuity:"+vastus*percent );
            Console.WriteLine("Total: ");

            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
