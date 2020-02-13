namespace Brothers_in_the_Bar
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BrothersInTheBar
    {
        static void Main()
        {
            var glasses = InputReader();
            var countOfDrinkingRounds = FindingConsecutiveAndRemove(glasses);
            OutputWriter(countOfDrinkingRounds);
        }

        private static List<int> InputReader()
        {
            Console.WriteLine("Write glasses below (array of integers):");
            while (true)
            {
                var inputNumbersInString = Console.ReadLine();
                try
                {
                    if (String.IsNullOrEmpty(inputNumbersInString))
                    {
                        throw new Exception("Input string was not in a correct format.");
                    }
                    return inputNumbersInString
                    .Split(new char[] { '[', ',', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(ch => int.Parse(ch))
                    .ToList();
                }
                catch
                {
                    Console.WriteLine("Input string was not in a correct format.");
                    Console.WriteLine("Please try again. Example: [1, 2, 3, 3, 3, 2] or 1 2 2 2 3 4");
                }
            }
        }

        private static int FindingConsecutiveAndRemove(List<int> glasses)
        {
            var countOfDrinkingRounds = 0;
            var consecutiveDrinks = new List<int>();

            for (int i = 0; i < glasses.Count; i++)
            {
                if (consecutiveDrinks.Count == 0)
                {
                    consecutiveDrinks.Add(glasses[i]);
                }
                else if (consecutiveDrinks[0] == glasses[i])
                {
                    consecutiveDrinks.Add(glasses[i]);

                    if (consecutiveDrinks.Count == 3)
                    {
                        consecutiveDrinks.Clear();
                        glasses.RemoveRange(i - 2, 3);
                        countOfDrinkingRounds += 1;
                        i = -1;
                    }
                }
                else
                {
                    consecutiveDrinks.Clear();
                    consecutiveDrinks.Add(glasses[i]);
                }
            }

            return countOfDrinkingRounds;
        }

        private static void OutputWriter(int countOfDrinkingRounds) => Console.WriteLine($"Numbers of rounds brothers drunk: {countOfDrinkingRounds}");
    }
}