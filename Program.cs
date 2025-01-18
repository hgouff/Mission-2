//Hannah Gouff
// section 1-14
using Mission_2;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice rolling simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int numDice = int.Parse(Console.ReadLine());

        int[] rollResults = RandomGenerator.RollDice(numDice); 

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numDice}.\n");
        for (int i = 0; i < rollResults.Length; i++)
        {
            int count = rollResults[i];
            double percentage = (double)count / numDice * 100;
            Console.Write($"{i + 2}: {new string('*', (int)Math.Round(percentage))}\n");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}