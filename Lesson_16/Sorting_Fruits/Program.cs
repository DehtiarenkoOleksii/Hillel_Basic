namespace Sorting_Fruits
{
    internal class Program
    {
        // Сортування: Дано список імен фруктів: {"Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.
        
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<string> fruits = new List<string> { "Яблуко", "Апельсин", "Ананас", "Банан", "Ківі" };
           
            var sortedFruits = fruits.OrderBy(f => f);

            Console.WriteLine("Список фруктів в алфавітному порядку:");
            foreach (var fruit in sortedFruits)
            {
                Console.WriteLine(fruit);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
