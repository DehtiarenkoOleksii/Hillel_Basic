namespace Digit_Palindrom
{
    internal class Program
    {
        // 1) Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
        static void Main(string[] args)
        {
            int number = 1000;

            if (number < 100 || number > 999)
                Console.WriteLine("The lenght should be 3 digits");
            else
            {
                int digit_1 = number % 10;
                int digit_2 = number % 100;
                digit_2 /= 10;
                number /= 100;
                Console.WriteLine($"{number}{digit_2}{digit_1} => {digit_1}{digit_2}{number}");
            }
            
               


            Console.ReadKey();
        }
    }
}
