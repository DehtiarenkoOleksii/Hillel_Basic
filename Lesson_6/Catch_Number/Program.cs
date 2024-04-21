using System;

namespace Catch_Number
{
    internal class Program
    {
        #region Task_4
        //Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
        //Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 

        #endregion
        static void Main(string[] args)
        {
            int[] originalArray = new int[10];
            int number = -1;
            // Fill array with random numbers
            FillArray(originalArray);
            // Print originalArray
            Print(originalArray);
            // Print all elements of the array until the element -1 is encountered
            CatchNumber(originalArray);
;
        }
        private static int GenerateRandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        private static int[] FillArray(int[] originalArray)
        {

            for (int i = 0; i < originalArray.Length; i++)
            {
                int number = GenerateRandomNumber(-5, 6);
                originalArray[i] = number; // set
            }
            return originalArray;
        }
        private static void Print(int[] originalArray)
        {

            foreach (int number in originalArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        private static void CatchNumber(int[] originalArray)
        {
            // Numbers BEFORE "-1" value
            for (int i = 0;i < originalArray.Length; i++)
            {
                if (originalArray[i] != -1) 
                {
                    Console.Write(originalArray[i] + " ");
                }
                else 
                {                   
                    break;
                }
            }
            Console.WriteLine(); // separator
            // Numbers UNTIL  "-1" value
            foreach (int num in originalArray)
                {
                if (num == -1)
                    {
                    Console.Write(num + " ");
                    break;
                    }
                Console.Write(num + " ");

            }
        }

    }
}
