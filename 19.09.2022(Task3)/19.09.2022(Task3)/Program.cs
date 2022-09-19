using System;
using System.Linq;

namespace _19._09._2022_Task3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 6, 8, 18, 25, 29, 32, 34, 48, 50, 58, 65, 25, 24, 28 };
            int[] evenDigits = convertEvenDigits(numbers);
            for (int i = 0; i < evenDigits.Length; i++)
            {
                Console.WriteLine(evenDigits[i]);
            }
        }

        static int[] convertEvenDigits(int[] array)
        {

            int[] evenArray = new int[] { };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenArray = evenArray.Concat(new int[] { array[i] }).ToArray();
                }

            }
            return evenArray;
        }
    }
}
