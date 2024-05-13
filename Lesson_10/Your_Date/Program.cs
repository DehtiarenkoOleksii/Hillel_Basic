using System.Text.RegularExpressions;
using System.Text;

namespace Your_Date
{
        // 2) Напишіть програму для створення власного представлення дати у форматі "день-місяць-рік".
        //Вимоги:
        //Користувач повинен мати можливість ввести день, місяць та рік.
        //Програма повинна перевірити введені значення на коректність та перетворити їх у формат "день-місяць-рік".
        //Дату потрібно вивести на консоль у форматі "день-місяць-рік" (наприклад, "10-05-2024").
        //Використайте StringBuilder для конструювання рядка з датою.
    internal class Program
    {

        #region Variant with with staging input and loop validation for each field
        static void Main(string[] args)
        {
            do
            {
                int day, month, year;
                Console.Clear();
                Console.Write("Enter Year: ");
                year = ValidateYear("Please enter a valid year greater than 0: ");
                Console.Write("Enter Month number: ");
                month = ValidateMonth("Please enter a valid month (1:12) : ");
                Console.Write("Enter Day: ");
                day = ValidateDay(month, year, "Please enter a valid day: ");
                PrintDateInStringBuilder(day, month, year);
                Console.WriteLine("Do you want enter one more date (Y/N)");
            } while (Console.ReadLine().ToLower() == "y");
        }
        static int ValidateYear(string errorMessage)
        {
            int input;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
                {
                    ClearLastLine();
                    Console.Write(errorMessage);
                }
                else
                {
                    break;
                }
            }

            return input;
        }
        static int ValidateMonth(string errorMessage)
        {
            int input;
            while (true)
            {
                // re-use parsing and validaiotn from ValidateYear
                input = ValidateYear(errorMessage);
                if (input > 12)
                {
                    ClearLastLine();
                    Console.Write(errorMessage);
                }
                else
                {
                    break;
                }
            }

            return input;
        }
        static int ValidateDay(int month, int year, string errorMessage)
        {
            // array for validate count days per month
            int[] daysInMonth = { 31, 28 + ((year % 4 == 0) ? 1 : 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int input;
            while (true)
            {
                // re-use parsing and validaiotn from ValidateYear
                input = ValidateYear(errorMessage);
                if (input > daysInMonth[month - 1])
                {
                    ClearLastLine();
                    Console.Write(errorMessage);
                }
                else
                {
                    break;
                }
            }

            return input;
        }
        //clear last line on the Console
        static void ClearLastLine()
        {
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.WriteLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
        // Format into StringBuilder for print
        static void PrintDateInStringBuilder(int day, int month, int year)
        {
            StringBuilder dateString = new StringBuilder();
            dateString.Append(day.ToString("00")).Append("-").Append(month.ToString("00")).Append("-").Append(year.ToString("0000"));
            Console.WriteLine(dateString.ToString());
        }
        #endregion
        #region variant with one line input, regex and int array
        //static void Main(string[] args)
        //{
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Enter Datein format  dd-MM-yyyy (like 10-05-2024):");

        //        string inputDate = Console.ReadLine();
        //        ValidateDateFormat(inputDate);

        //        Console.WriteLine("Do you want enter one more date (Y/N)");
        //    } while (Console.ReadLine().ToLower() == "y");
        //}
        //// Validation logic for input
        //static void ValidateDateFormat(string inputDate)
        //{

        //    Regex regex = new Regex(@"^\d{2}-\d{2}-\d{4}$");
        //    // check for matching regex and filter types of validaion
        //    if (regex.IsMatch(inputDate))
        //    {

        //        int[] dateParts = ParseDate(inputDate);

        //        if (dateParts != null && IsValidDate(dateParts))
        //        {
        //            FormatAndPrintDate(dateParts);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Incorrect Date");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Incorrect format");
        //    }
        //}
        //// coverting into int array for logic validation
        //static int[] ParseDate(string inputDate)
        //{
        //    string[] inputDateStrings = inputDate.Split('-');
        //    int[] dateParts = new int[3];


        //    if (inputDateStrings.Length != 3)
        //        return null;

        //    for (int i = 0; i < inputDateStrings.Length; i++)
        //    {
        //        if (!int.TryParse(inputDateStrings[i], out dateParts[i]))
        //        {
        //            return null;
        //        }
        //    }

        //    return dateParts;
        //}
        //// logic validation
        //// [0] - day
        //// [1] - month
        //// [2] - year
        //static bool IsValidDate(int[] array)
        //{
        //    //validation for year
        //    if (array[2] < 1)
        //        return false;
        //    //validation for month
        //    if (array[1] < 1 || array[1] > 12)
        //        return false;
        //    // Validation for days with checkin count of day per month
        //    int[] daysInMonth = { 31, 28 + ((array[2] % 4 == 0) ? 1 : 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //    return (array[0] >= 1 && array[0] <= daysInMonth[array[1] - 1]);
        //}
        //// Format into StringBuilder for print
        //static void FormatAndPrintDate(int[] dateParts)
        //{
        //    StringBuilder formattedDate = new StringBuilder();
        //    formattedDate.Append($"{dateParts[0]:00}-{dateParts[1]:00}-{dateParts[2]}");
        //    Console.WriteLine("Formatted Date: " + formattedDate);
        //}
        #endregion
    }
}
