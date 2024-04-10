namespace Arithmetic_Mean
{
    internal class Program
    {
        // Написати програму, яка обчислює середнє арифметичне двох чисел.
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter num1: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter num2: ");
            string? input2 = Console.ReadLine();

            num1 = int.Parse(input1);
            num2 = int.Parse(input2);

            float average = ((float)num1 + num2) / 2;

            Console.WriteLine($"Average = {average}");

            //Delay
            Console.ReadKey();
        }
    }
}
