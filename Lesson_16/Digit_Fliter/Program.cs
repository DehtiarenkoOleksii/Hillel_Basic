namespace Digit_Fliter
{
    internal class Program
    {
        // Фільтрація: Дано список цілих чисел: {2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.
        static void Main()
        {
            List<int> numbers = new List<int> { 2, 5, 8, 12, 15, 18, 22 };

            var filteredNumbers = numbers.Where(n => n > 10);

            Console.WriteLine("Числа більше 10:");
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
