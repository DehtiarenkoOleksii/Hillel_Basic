using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phone_Book
{
    public static class Helper
    {

        /// <summary>
        /// Clears the last line of console
        /// </summary>
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        /// <summary>
        /// Reads and validates a phone number from the user.
        /// </summary>
        public static string ReadPhoneNumber()
        {
            string phoneNumber;
            while (true)
            {
                phoneNumber = Console.ReadLine();
                bool isValidPhoneNumber = Regex.Match(phoneNumber, @"^\+?[1-9]\d{1,14}$").Success;
                if (isValidPhoneNumber == false)
                {
                    ClearLastLine();
                    Console.Write("Invalid phone number. Try again: ");
                }
                else return phoneNumber;
            }
        }
    }
}
