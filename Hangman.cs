using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Random word chooser
            string[] Words = new string[4] { "TAHELAEV", "KUUUURIA", "MARI", "TORU" };
            Random rnd = new Random();
            int rndWord = rnd.Next(0, 4);
            string Word = Words[rndWord];
            Console.WriteLine($"{Word}");
            
            // Tell the user the number of letters with dashes
            char[] WordLenght = new char[Word.Length];
            for (int i = 0; i < WordLenght.Length; i++)
            {
                WordLenght[i] = '_';
            }

            for (int i=0;i<WordLenght.Length; i++)
            {
                Console.Write(WordLenght[i] + " ");
            }
            Console.WriteLine();

            int count = 0; 

            List<string> Letters = new List<string>(); //kasutatud tahtede jaoks

            do
            {
                Console.WriteLine($"\nGuessed letters {string.Join(",", Letters)}");
                Console.Write("\nSisesta taht: ");
                char input = Console.ReadLine().ToUpper().ToCharArray()[0];
               
                //muudab chari stringiks  ning lisab sisestatud  t'he Letters listi                              
                string array = input.ToString().ToUpper();
                Letters.Add(array);
                

                for (int i = 0; i < Word.Length; i++)
                {
                    //asendab dashi tahega
                    if (Word[i] == input)
                    {
                        count++; //kontrollib counti millal v'ljuda
                        WordLenght[i] = input; //asendab dashi inputiga
                        Console.Write(WordLenght[i] + " ");
                    }
                    //kirjutab valja mis on juba arvatud                    
                                       
                    else
                    {
                       Console.Write(WordLenght[i] + " ");
                    }
               

                }

            }

            while (count < WordLenght.Length);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nYou guessed right!!");
            Console.ResetColor();
            Console.ReadLine();

            
            /*while(true)
            {
                Console.Write("\nSisesta taht: ");
                string input = Console.ReadLine();
                            
                if (input == "-1")
                {
                    break;
                }
                Letters.Add(input);

                Console.WriteLine($"\nSisestud tahed: {string.Join(", ", Letters)}");
            }
            */    
        }
    }
}
