using System;

namespace Mission_2
{
    public class RandomGenerator
    {
        private static Random _random = new Random();

        public static int[] RollDice(int numRolls)
        {
            int[] results = new int[11]; // For sums 2-12
            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = _random.Next(1, 7);
                int dice2 = _random.Next(1, 7);
                int sum = dice1 + dice2;
                results[sum - 2]++;
            }
            return results;
        }
    }
}