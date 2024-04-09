namespace Mixed_Digits
{
    internal class Program
    {
        // Дано тризначне число.Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
        static void Main(string[] args)
        {
            int number = 100;

            if (number < 100 || number > 999)
                Console.WriteLine("The number should be in range 100:999");
            else
            {

                int digit_1 = number % 10;
                int digit_2 = number % 100;
                digit_2 /= 10;
                number /= 100;
                
                int mixed_number =  + digit_2 * 100 + number * 10  + digit_1 ;
                Console.WriteLine($"{number}{digit_2}{digit_1} => {mixed_number}");
            }



            //Delay
            Console.ReadKey();
        }
    }
}
