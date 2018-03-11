using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        static string[] Words = { "Blue", "Yellow", "Submarine", "Rookie" };
        static string Word;
        static int Lives = 5;
        static int LettersRevealed = 0;
        static bool won = false; //statment to control if you won the game
        static List<string> UsedLetters = new List<string>(); //List to hold used letters


        public static void Play()
        {
            //Chooses random word from Words string
            Random rndNumber = new Random();
            Word = Words[rndNumber.Next(Words.Length)].ToUpper();

            //Makes letters to dashes and returns them on screen
            char[] WordLenght = new char[Word.Length];
            for (int i = 0; i < WordLenght.Length; i++)
            {
                WordLenght[i] = '_';
                Console.Write(WordLenght[i] + " ");
            }

            while (!won && Lives > 0) //Lasts until bool is true or Lives are 0
            {
                Console.Write("\nEnter a Letter > ");
                string input = Console.ReadLine().ToUpper();
                UsedLetters.Add(input.ToUpper());
                char Guess = input[0];//Makes input to char
                Console.WriteLine();

                //Controls if Word contains Guessed word
                if (Word.Contains(Guess))
                {
                    //Shows The Table
                    for (int i = 0; i < Word.Length; i++)
                    {
                        //Puts the Guessed Letter to its Correct place and displays it
                        if (Word[i] == Guess)
                        {
                            LettersRevealed++;
                            WordLenght[i] = Guess;
                            Console.Write(WordLenght[i] + " ");
                        }
                        //Displays the empty dashes
                        else
                            Console.Write(WordLenght[i] + " ");
                    }
                    //Controls if the Word has been guessed
                    if (LettersRevealed == WordLenght.Length)
                        won = true;
                    Console.WriteLine();
                }
                //if Wprd doesn\t contain Guessed Letter
                else
                {
                    //Displays the Full Table w Gussed/NG Letters
                    for (int i = 0; i < Word.Length; i++)
                    {
                        if (Word[i] == Guess)
                        {
                            LettersRevealed++;
                            WordLenght[i] = Guess;
                            Console.Write(WordLenght[i] + " ");
                        }

                        else
                            Console.Write(WordLenght[i] + " ");
                    }

                    //Loses a Live and displays Lives Left
                    Lives--;
                    Text($"\nWrong Letter! {Lives} Lives left.", "");

                }
                //Displays Used Letters
                Text($"Used Letters {string.Join(",", UsedLetters)}", "Yellow");
            }
            if (Lives > 0)
                Text("Congrats you won", "Cyan");
            else
                Text("You lost!", "Red");
        }

        static void Text(string message, string color)
        {

            if (color == "Cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (color == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game.Play();

            Console.ReadKey();
        }
    }
}
