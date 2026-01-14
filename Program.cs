using System;

namespace DiceSimulator;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("How many times would you like to roll the dice?");
            int numRolls = int.Parse(Console.ReadLine());


            // Use second class
            DiceSimulator simulator = new DiceSimulator();

            // Pass number of rolls and pass array back
            int[] rollResults = simulator.SimulateRolls(numRolls);

            // Output
            Console.WriteLine("DICE ROLLING RESULTS");
            Console.WriteLine("Total Number of Rolls = " + numRolls + "\n.");

            // Loop through for each combo
            for (int i = 2; i <= 12; i++)
            {
                int count = rollResults[i - 2];
                double percentage = (double)count / numRolls * 100;

                Console.Write(i + ": ");

                for (int j = 0; j < (int)percentage; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the dice simulator!");
        }

    }
