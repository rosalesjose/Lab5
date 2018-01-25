using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunProgram = true;
            while (RunProgram)
            {                
                int SidesOfDice = ReadUserInput("Please enter the number of sides for your pair of dice.");
                Console.WriteLine("Number of sides: " + SidesOfDice);
                Console.Clear();
                Console.WriteLine("Would you like to roll the dice?");

                char RollDice = char.Parse(Console.ReadLine());
                bool GenerateDice = true;

                if (RollDice == 'y' || RollDice == 'Y')
                {
                    GenerateDice = true;                    
                }
                else
                {
                    GenerateDice = false;                    
                }

                while (GenerateDice)
                {
                    int Roll1 = GenerateRandom(SidesOfDice);
                    System.Threading.Thread.Sleep(20);
                    int Roll2 = GenerateRandom(SidesOfDice);

                    Console.WriteLine("You rolled: {0} and {1}", Roll1, Roll2);
                    GenerateDice = false;
                }

                Console.WriteLine("\nRun again (Y/N)?");
                char DoAgain = char.Parse(Console.ReadLine());

                if (DoAgain == 'y' || DoAgain == 'Y')
                {                    
                    Console.Clear();
                }
                else
                {
                    RunProgram = false;
                }

            }
        }

        public static int ReadUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            int SidesOfDice = int.Parse(Console.ReadLine());
            return SidesOfDice;
        }

        public static int GenerateRandom(int SidesOfDice)
        {
            Random num1 = new Random();
            int Dice1 = num1.Next(1, SidesOfDice);
            return Dice1;
        }
    }
}