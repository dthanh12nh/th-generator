using System;

namespace TH.Generator
{
    public static class NumberGenerator
    {
        public static int[] GetRandomNumbers(int length, int min, int max)
        {
            int[] randomNumbers = new int[length];
            var random = new Random();
            
            unsafe
            {
                fixed (int* p = randomNumbers)
                {
                    int* current = p;
                    for (int i = 0; i < length; i++)
                    {
                        *current = random.Next(min, max + 1);
                        current++;
                    }
                }
            }

            return randomNumbers;
        }
    }
}
