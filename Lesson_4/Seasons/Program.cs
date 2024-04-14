namespace Seasons
{
    internal class Program
    {
        //Написати програму, в якій користувач вводить номер місяця.
        //Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь».
        //У будь-якому іншому випадку - "Немає такого місяця на цій планеті" .
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть номер місяця : ");
            int month = Parse(Console.ReadLine());
            string season = GetSeason(month);
            Console.WriteLine(season);
            Console.ReadKey();
        }
        private static int Parse(string input)
        {
            return int.Parse(input);
        }
        private static string GetSeason (int month) 
        {
           
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    return "Зима";
                case 3:
                case 4:
                case 5:
                    return "Весна";
                case 6:
                case 7:
                case 8:
                    return "Літо";
                case 9:
                case 10:
                case 11:
                    return "Осінь"  ;
                default:
                    return "Немає такого місяця на цій планеті";
            }
        }
    }
}
