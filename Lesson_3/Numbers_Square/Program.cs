namespace Numbers_Square
{
    internal class Program
    {
        // Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math).
        static void Main(string[] args)
        {
            double number;
            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());
            number = Math.Pow(number,2);
            Console.WriteLine($"Square for you number will be: {number}");

            //Delay
            Console.ReadKey();
        }
    }
}
