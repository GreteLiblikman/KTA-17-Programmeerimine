﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Suvalinekaardi_valik
{
    class Program
    {
        static void Main(string[] args)
        {

            Welcoming();

            Random randomNumber = new Random();
            string[] CardMark = new string[4] { "C", "S", "D", "H" };
            Random randomName = new Random();
            

            //Generating Cards to Player
            int c1 = randomNumber.Next(1, 11);
            int c2 = randomNumber.Next(1, 11);

            int index = randomName.Next(0, 4);
            int index2 = randomName.Next(0, 4);

            string Name = CardMark[index];
            string Name2 = CardMark[index];


            //Generating Cards to Dealer
            int c3 = randomNumber.Next(1, 11);
            int c4 = randomNumber.Next(1, 11);

            int index3 = randomName.Next(0, 4);
            int index4 = randomName.Next(0, 4);

            string Name3 = CardMark[index3];
            string Name4 = CardMark[index4];

            //Calculating initial scores
            int PlayerPoints = c1 + c2;
            int HousePoints = c3 + c4;

            Console.WriteLine($"You have been dealt: {c1}{Name}, {c2}{Name2} Points: {PlayerPoints}");

            Console.WriteLine($"House has been dealt: {c3}{Name3}, {c4}{Name4}? Points: {HousePoints}");

            while (true)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");

                Console.Write("\nI choose: ");
                int awnser = int.Parse(Console.ReadLine());

                if (awnser == 1)
                {
                    //Generating a card 4 Player
                    int c5 = randomNumber.Next(1, 11);
                    int index5 = randomName.Next(0, 4);
                    string Name5 = CardMark[index5];

                    //Generating a card 4 Dealer  
                    if (HousePoints < 17)
                    {
                        int c6 = randomNumber.Next(1, 11);
                        int index6 = randomName.Next(0, 4);
                        string Name6 = CardMark[index6];
                        HousePoints = HousePoints + c6;
                    }
                    //Calculating new score
                    PlayerPoints = PlayerPoints + c5;


                    Console.WriteLine($"You have been dealt: {c5}{Name5} Points: {PlayerPoints}");
                    Console.WriteLine($"House has been dealt: [?] Points: {HousePoints}");

                    if (PlayerPoints > 21)
                    {
                        Console.WriteLine("You are bust!");
                        break;
                    }
                    continue;

                }

                else if (awnser == 2)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("That is not a valid response. Try again.");
                    continue;
                }
            }

            Winner(PlayerPoints, HousePoints);

            Console.WriteLine("\nPress any key to continue....");
            Console.ReadLine();
        }
        static void Welcoming()
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine("-------------------------------------------------------- \n");

        }

        static void KQJ()
        {
            int randomObject = new Random();

            int RandomNumber = randomObject.Next(3);
            switch(RandomNumber)
            {
                case 0:
                    {
                        Console.Write("Q");
                        break;
                    }
                case 1:
                    {
                        Console.Write("K");
                        break;
                    }
                case 2:
                    {
                        Console.Write("A");
                        break;
                    }
            }


        }
        
        static void Winner(int PlayerPoints, int HousePoints)
        {
            Console.WriteLine($"\n\nYou have points {PlayerPoints} vs. House {HousePoints}  points");
            if (PlayerPoints > HousePoints && PlayerPoints <= 21)
                Console.WriteLine("Player Wins!");
            else if (HousePoints > PlayerPoints && HousePoints <= 21 || HousePoints > PlayerPoints && HousePoints <= 21 || PlayerPoints > 21)
                Console.WriteLine("House wins!");
            else if (HousePoints > 21 && PlayerPoints > 21)
                Console.WriteLine("Draw!");
        }
    }
}