using System;

namespace Positive_Numbers
{
    internal class Program
    #region Task_1
    // Задати масив із 10 елементів. Заповнити цей масив рандомними числами від -100 до 100.
    // Знайти кількість додатніх чисел у масиві.
    // Вивести на екран масив і кількість порахованих чисел. 
    //{5, -9, 8, 7} =>{5, -9, 8, 7} , кількість додатних чисел = 3  
    //(фігурні дужки і коми, звісно, можна не виводити в консоль!!!)
    #endregion
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] mixedArray = new int[10];

            // Fill array with random numbers
            FillArray(mixedArray);
            // Print full array with random numbers
            Print(mixedArray);

            Console.Write("=> "); // separator

            // Print positive numbers and their count
            PrintPositiviePart(mixedArray);

            //Delay
            Console.ReadKey();

        }

        // use count and print positive numbers in one method in cause of economic loops and for optimization
        private static void PrintPositiviePart(int[] mixedArray)
        {
            int countPositiveNumbers = 0;
            for (int i = 0; i < mixedArray.Length; i++)
            {
                if (mixedArray[i] > 0)
                {
                    Console.Write(mixedArray[i] + " ");
                    countPositiveNumbers++;
                }
            }
            Console.Write($", кількість додатних чисел = {countPositiveNumbers}");
        }

        private static int GenerateRandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        private static int[] FillArray(int[]  mixedArray)
        {
           
            for (int i = 0; i < mixedArray.Length; i++)
            {
                int number = GenerateRandomNumber(-100, 101);
                mixedArray[i] = number; // set
            }
            return mixedArray;
        }
        private static void Print(int[] mixedArray)
        {
            foreach (int number in mixedArray)
            {
                Console.Write(number + " ");
            }


        }

        
    }
}
