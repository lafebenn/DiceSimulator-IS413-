using System;

namespace DiceSimulator
{}

internal class Program
{
    private static void Main(string[] args)
    {
        // Intro
        Console.WriteLine("How many times would you like to roll the dice?");
        int num_roll = int.Parse(Console.ReadLine());
        
        // Randomizer function
        Random rnd = new Random();
        
        // Out of 13 so the index is the same as the combo roled ([2] is for the combo 2)
        int[] rollResults = new int[11];
        
        // Rolling logic
        Console.WriteLine("\nRolling...");
        for (int i = 0; i < num_roll; i++)
        {
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            int total = (die1 + die2);
            rollResults[total - 2]++;
        }

        //Output
        Console.WriteLine("DICE ROLLING RESULTS");
        Console.WriteLine("Total Number of Rolls = " + num_roll + "\n.");
        
    //Loop through for each combo
    for (int i = 2; i <= 12; i++)
    {
        int count = rollResults[i - 2];
        double percentage = (double)count / num_roll * 100;

        Console.Write(i + ": ");
        
        for (int j = 0; j< (int)percentage; j++)
        {
            Console.Write("*");
        }
    
        Console.WriteLine();
    }
    
    Console.WriteLine("Thank you for using the dice simulator!");
    }

}