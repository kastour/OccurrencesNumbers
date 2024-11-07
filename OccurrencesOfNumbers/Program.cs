using System;
using System.Linq;

namespace OccurrencesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = GenerateRandamArray();

            var occurrencesForEveryNumber = numbers.ToList().GroupBy(x => x).ToList();
            foreach (var numberOccurrence in occurrencesForEveryNumber)
            {
                string timeOrtimes = numberOccurrence.Count() > 1 ? "times." : "time";
                Console.WriteLine($"Number {numberOccurrence.Key} occurrences {numberOccurrence.Count()} {timeOrtimes}");
            }
            Console.ReadLine();
        }

        /// <summary>
        ///Generate an array of 100 random integers between 20 and 40
        /// </summary>
        /// <returns>an array of 100 random integers between 20 and 40</returns>
        public static int[] GenerateRandamArray()
        {
            Random random = new Random();
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(20, 41); // Upper bound is exclusive, so 41 means it includes 40
            }
            return numbers;
        }
    }
}
