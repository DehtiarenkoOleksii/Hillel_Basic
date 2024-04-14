namespace Number_Comparison
{
    internal class Program
    {
        // Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа.
        // Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння (чи рівні значення, а якщо ні, яке число більше/менше).
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
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
            return number1 == number2 ? $"Числа {number1} і {number2} - рівні" : (number1 > number2 ? $"{number1} більше ніж {number2}" : $"{number1} менше ніж {number2}");
        }


    }
}
