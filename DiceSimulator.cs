using System;

namespace DiceSimulator;


public class DiceSimulator
{
    // Simulate Rolls function
    public int[] SimulateRolls(int numRolls)
    {
        // Randomizer function
        Random rnd = new Random();

        // Array of how many times each combo is rolled
        int[] rollResults = new int[11];

        // Loop to Simulate each roll, according to number of Rolls specified
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            int total = die1 + die2;

            rollResults[total - 2]++;
        }
        
        // Pass results back
        return rollResults;
    }
}
        