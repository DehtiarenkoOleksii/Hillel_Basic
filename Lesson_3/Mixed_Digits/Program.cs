namespace Mixed_Digits
{
    internal class Program
    {
        // Дано тризначне число.Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter three-digit integer number: ");
            string? input1 = Console.ReadLine();
            number = int.Parse(input1);

            if (number < 100 || number > 999)
                Console.WriteLine("The number should be in range 100:999");
            else
            {

                int digit_1 = number % 10;
                int digit_2 = number % 100;
                digit_2 /= 10;
                int digit_3 = number / 100;

                int mixed_number =  + digit_2 * 100 + digit_3 * 10  + digit_1 ;
                Console.WriteLine($"{number} => {mixed_number}");
            }



            //Delay
            Console.ReadKey();
        }
    }
}
