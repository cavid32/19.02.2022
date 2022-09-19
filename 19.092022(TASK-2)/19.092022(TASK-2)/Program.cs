using System;

namespace _19._092022_TASK_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number1 = { 4, 5, 2, 6, 4, 3 };
            int[] number2 = { 7, 4, 2, 76, 45, 65 };



            for (int i = 0; i < number1.Length; i++)
            {
                bool isExists = false;
                for (int j = 0; j < number2.Length; j++)
                {
                    if (number1[i] != number2[j])
                    {
                        isExists = false;
                    }
                    else {
                        isExists = true;
                        break;
                    }
                }

                if (isExists==false)
                {
                    Console.WriteLine(number1[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
