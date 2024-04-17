namespace GuessNumber
{
    internal class Program
    //  Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його.
    //  У разі неправильної відповіді програма підказує «більше» або «менше»
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int mysteriousNumber = GenerateRandomNumber(147);
            CompareNumbers(mysteriousNumber);
            
        }
        private static int GenerateRandomNumber(int limit)
        {
            Random rand = new Random();
            return rand.Next(1, limit);
        }
        private static void CompareNumbers(int mysteriousNumber)
        {
            int inputNumber;
            do 
            {
                Console.Write("Введіть число : ");
                inputNumber = Parse(Console.ReadLine());
                if (inputNumber < mysteriousNumber)
                {
                    Console.WriteLine("Введіть більше число!");
                }
                else if (inputNumber > mysteriousNumber)
                {
                    Console.WriteLine("Введіть менше число!");
                }

            }
            while (inputNumber != mysteriousNumber);
            Console.WriteLine("Ви вгадали!!!");
        }
        static int Parse(string input)
        {
            return int.Parse(input);
        }
    }
}
