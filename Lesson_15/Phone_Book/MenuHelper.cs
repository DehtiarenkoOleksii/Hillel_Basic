using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    public static class MenuHelper
    {
        /// <summary>
        /// Displays a menu based on enum values and allows the user to navigate through the options.
        /// </summary>
        /// <param name="canCancel">Determines if the user can cancel the selection by pressing Escape.</param>
        /// <param name="userEnum">Enum type that defines the menu options.</param>
        /// <param name="spacingPerLine">Number of spaces between columns.</param>
        /// <param name="optionsPerLine">Number of options per line.</param>
        /// <param name="startX">Starting cursor position on the X-axis.</param>
        /// <param name="startY">Starting cursor position on the Y-axis.</param>
        /// <returns>Index of the selected option.</returns>
        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 30, int optionsPerLine = 2,
            int startX = 1, int startY = 1)
        {
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(userEnum.GetType()).Length;
            do
            {
                Console.Clear();

                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(Enum.GetName(userEnum.GetType(), i));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (currentSelection % optionsPerLine > 0)
                            currentSelection--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (currentSelection % optionsPerLine < optionsPerLine - 1)
                            currentSelection++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (currentSelection >= optionsPerLine)
                            currentSelection -= optionsPerLine;
                        break;
                    case ConsoleKey.DownArrow:
                        if (currentSelection + optionsPerLine < length)
                            currentSelection += optionsPerLine;
                        break;
                    case ConsoleKey.Escape:
                        if (canCancel)
                            return -1;
                        break;
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }
    }
}
