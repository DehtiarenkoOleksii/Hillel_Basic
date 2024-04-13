﻿namespace Number_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1 : ");
            int number1 = Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int number2 = Parse(Console.ReadLine());

            // Comparing entered numbers
            string result = CompareNumbers(number1, number2);           
            Console.WriteLine(result);

            //Delay
            Console.ReadKey();

        }
        static int Parse(string input)
        {
            return int.Parse(input);
        }
        static string CompareNumbers ( int number1, int number2) 
        {
            //// else if
            //if (number1 > number2)
            //{
            //    return $"{number1} > {number2}";
            //}
            //else if (number1 < number2)
            //{
            //    return $"{number1} < {number2}";
            //}
            //else
            //{
            //    return $"{number1} = {number2}";
            //}

            // Ternar operator
            return number1 == number2 ? $"{number1} = {number2}" : (number1 > number2 ? $"{number1} > {number2}" : $"{number1} < {number2}");
        }


    }
}