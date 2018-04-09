using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Harjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            int MinYear;
            int MaxYear;
            int GenData;
            
            Console.Write("Sisestage minimaalne aasta arv: ");
            MinYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sisestage maximaalne aasta arv: ");
            MaxYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sisestage suvaliselt genereeritavate andmete hulk ");
            GenData = Convert.ToInt32(Console.ReadLine());

            var rnd = new Random();

            DateTime startDate = new DateTime(MinYear, 1, 1);
            DateTime endDate = new DateTime(MaxYear, 1, 1);

            for (int i = 0; i < GenData; i++)
            {
                TimeSpan timeSpan = endDate - startDate;
                TimeSpan newSpan = new TimeSpan(0, rnd.Next(0, (int)timeSpan.TotalMinutes), 0);
                DateTime newDate = startDate + newSpan;
                Console.WriteLine(newDate.ToString("d"));
            }

            Console.ReadLine();
        }
    }
}
