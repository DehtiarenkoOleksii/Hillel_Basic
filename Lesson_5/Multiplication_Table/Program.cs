namespace Multiplication_Table
{
    internal class Program
    // Доробити таблицю множення - зробити гарний вивід в консоль.
    {
        static void Main(string[] args)
        {
            // Таблиця множення

            // Multiplication Table in range 1:5 in top level part
            MultiplicationTable(1, 5);

            Console.WriteLine(); // separator

            // Multiplication Table in range 6:10 in below level part
            MultiplicationTable(6, 10);

            //Delay
            Console.ReadLine();
        }
        static void MultiplicationTable(int min, int max)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = min; j <= max; j++) 
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
