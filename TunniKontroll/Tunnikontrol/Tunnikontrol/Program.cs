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
            Encoding enc = new UTF8Encoding(true, true);

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            Console.WriteLine("--------------------------------------------------------------");



            Console.Write("Enter price op food item[-1 to quit]: ");
            string input = Console.ReadLine();
            double hind = double.Parse(input);

            while (true)
            {
                                
                if (hind != -1)
                {
                    hind = hind + hind;
                }

                if (hind == -1)

                {
                    Console.WriteLine("");
                    break;
                }
             

            }

            Console.WriteLine("--------------------------------------------------------------");
            int percent = 15;






            Console.WriteLine($"Subtotal:" + hind);
            Console.WriteLine("15% Gratuity:");
            Console.WriteLine("Total: " +hind*percent);

            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
