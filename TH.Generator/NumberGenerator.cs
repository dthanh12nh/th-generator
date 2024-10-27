using System;

namespace TH.Generator
{
    public static class NumberGenerator
    {
        /// <summary>Return an array of random numbers</summary>
        /// <param name="length">Length of the array</param>
        /// <param name="min">The number is greater or equal to <paramref name="min"/></param>
        /// <param name="max">The number is less than <paramref name="max"/></param>
        /// <returns></returns>
        public static int[] GetRandomNumbers(int length, int min, int max)
        {
            var numbers = new int[length];
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(min, max);
            }

            return numbers;
        }
    }
}
