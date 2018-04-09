using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Harjutus
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<DateTime> BD = new List<DateTime>();

            DateTime startDate = new DateTime(1940, 1, 1);
            DateTime endDate = new DateTime(2018, 1, 1);

            var rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                TimeSpan timeSpan = endDate - startDate;
                TimeSpan newSpan = new TimeSpan(0, rnd.Next(0, (int)timeSpan.TotalMinutes), 0);
                DateTime newDate = startDate + newSpan;
                BD.Add(newDate);
            }

            //Kuvab sünnipäevad 
            foreach (DateTime j in BD)
            Console.WriteLine(j.ToString("d"));
            Console.WriteLine();

            var Now = DateTime.Now;

            //Maximaalne vanus
            int Maxage = Now.Year - SortAscending(BD)[0].Year;
            if (Now < SortAscending(BD)[0].AddYears(Maxage))
                Maxage--;
            Console.WriteLine($"Vanim inimene: {Maxage}");

            //Minimaalne vanus
            int minAge = Now.Year - SortAscending(BD)[BD.Count - 1].Year;
            if (Now < SortAscending(BD)[BD.Count - 1].AddYears(minAge))
                minAge--;
            Console.WriteLine($"Noorim inimene: {minAge}");

            //Keskmine vanus aastates

            int AgeToughether = 0;
            int BDCount = 0;

            foreach (DateTime BDay in BD)
            {
                var AgeNow = Now.Year - BDay.Year;
                if (Now < SortAscending(BD)[BD.Count - 1].AddYears(minAge))
                    AgeNow--;
                AgeToughether += AgeNow;
                BDCount++;
                //Console.WriteLine(AgeNow);
            }

            Console.WriteLine($"Keskmine vanus aastates on: {AgeToughether/BDCount}");

            //Kasvav järjekord
            Display(SortAscending(BD), "\nKasvav järjekord:");

            //Populaarseim kuu
           // foreach (DateTime month in BD)
            // Console.WriteLine(month.ToString("MMM"));

            Console.ReadKey();
        }

        static List<DateTime> SortAscending(List<DateTime> BD)
        {
            BD.Sort((a, b) => a.CompareTo(b));
            return BD;
        }

        static void Display(List<DateTime> BD, string message)
        {
            Console.WriteLine(message);
            foreach (var datetime in BD)
            {
                Console.WriteLine(datetime.ToString("d"));
            }
            Console.WriteLine();
        }
    }
}
