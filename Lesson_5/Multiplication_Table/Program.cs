namespace Multiplication_Table
{
    internal class Program
    // Доробити таблицю множення - зробити гарний вивід в консоль.
    {
        static void Main(string[] args)
        {
            // Таблиця множення

            for (int i = 1; i <= 10; i++) // 1*1=1
            {
                Console.WriteLine();
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++) // 1*1=1
            {
                Console.WriteLine();
                for (int j = 6; j <= 10; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
            }
            Console.ReadLine();
        }
    }
}
