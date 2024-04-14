namespace Quadratic_Equation
{
    internal class Program
    {
        // Коефіцієнти a, b, c рівняння це рандомні числа.
        // a* x^2 + b* x + c = 0
        //D = b^2 - 4 * a* c
        //В залежності від знаку дискримінанту рівняння може:
        //1) не мати коренів - D< 0 
        //2) один корінь - D = 0
        //3) два корені - D> 0
        //Виводимо рівняння в консоль, про кількість коренів інформуємо користувача.
        //Нагадую про написання власних методів, розділення обовязків між методами.
        //*** (плюсик в карму) якщо рівняння має корені, то вивести їх також в консоль.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // generate random numbers for variables
            int a = GenerateRandomNumber(101);
            int b = GenerateRandomNumber(101);
            int c = GenerateRandomNumber(101);

            Console.WriteLine($" Рівняння: {a}x² + {b}x + {c} = 0");

            // Get Descriminant value
            int descriminant = GetDescriminant(a, b, c);
            //Solving the equation
            string answer = GetEquationAnswer(a,b, descriminant);
            //Print
            PrintResultOfCheck( descriminant, answer);  
        }
        private static int GenerateRandomNumber(int limit)
        {
            Random rand = new Random();
            return rand.Next(limit);
        }

        private static int GetDescriminant(int a, int b, int c)
        {
            int d = b * b - 4 * a * c;
            return d;
        }
        private static string GetEquationAnswer(int a, int b, int d)
        {

          
            if (d < 0) 
            {
                return "не має коренів";
            }
            else if (d == 0) 
            {
                double x = -b / (2 * a)  ;
                return $"має один корінь х1 = {x}";
            }
            else 
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                return $"має два коріня: х1 = {x1} і x2 = {x2}";
            }
        }
        private static void PrintResultOfCheck(int GetDescriminant, string GetEquationAnswer)
        {
            Console.WriteLine($" Дискримінант = {GetDescriminant}\n Отже {GetEquationAnswer}");
        }
    }
}
