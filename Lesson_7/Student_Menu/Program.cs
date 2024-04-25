

namespace Student_Menu
{
    internal class Program
    {
        // global variable
        static int[][] marks;
        static void Main(string[] args)
        {
            // initialize array of arrays with random length and random values
            marks = InitializeData();
            OpenMainMenu();

        }
        // Main menu
        static void OpenMainMenu()
        {
            while (true)
            {
                int input = MultipleChoice(true, new MainMenu());
                switch ((MainMenu)input)
                {
                    case MainMenu.Display_Marks:
                        OpenDisplayMenu();
                        break;
                    case MainMenu.Average_Mark:
                        OpenAverageMenu();
                        break;
                    case MainMenu.Set_Mark:
                        OpenSetMenu();
                        break;
                    case MainMenu.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
        // sub-menu which display all marks depends on subject
        static void OpenDisplayMenu()
        {
            while (true)
            {
                int input = MultipleChoice(true, new SubMenu());
                switch ((SubMenu)input)
                {
                    case SubMenu.Back:
                        OpenMainMenu();
                        break;
                    case SubMenu.Math:
                        PrintMarks("Math", marks[0]);
                        break;
                    case SubMenu.History:
                        PrintMarks("History", marks[1]);
                        break;
                    case SubMenu.Language:
                        PrintMarks("Language", marks[2]);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        // sub-menu which calculate average from all marks depends on subject
        static void OpenAverageMenu()
        {
            while (true)
            {
                int input = MultipleChoice(true, new SubMenu());
                switch ((SubMenu)input)
                {
                    case SubMenu.Back:
                        OpenMainMenu();
                        return;
                    case SubMenu.Math:
                        PrintAverage("Math", marks[0]);
                        break;
                    case SubMenu.History:
                        PrintAverage("History", marks[1]);
                        break;
                    case SubMenu.Language:
                        PrintAverage("Language", marks[2]);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        // sub-menu where you can add mark for anu subject
        static void OpenSetMenu()
        {
            while (true)
            {
                int input = MultipleChoice(true, new SubMenu());
                switch ((SubMenu)input)
                {
                    case SubMenu.Back:
                        OpenMainMenu();
                        return;
                    case SubMenu.Math:
                        Console.Write("\nEnter number: ");
                        marks[0] = SetMark(marks[0]);

                        break;
                    case SubMenu.History:
                        Console.Write("\nEnter number: ");
                        marks[1] = SetMark(marks[1]);

                        break;
                    case SubMenu.Language:
                        Console.Write("\nEnter number: ");
                        marks[2] = SetMark(marks[2]);

                        break;
                    default:
                        break;
                }
                Console.ReadLine(); // Specially added for show input
                Console.Clear();
            }
        }
        public static int[][] InitializeData()
        {
            Random random = new Random();
            int countOfSetMarks = random.Next(2, 6);
            int[] marksMath = new int[countOfSetMarks];
            int[] marksHistory = new int[countOfSetMarks];
            int[] marksLanguage = new int[countOfSetMarks];
            int[][] marks = new int[3][];
            marks[0] = marksMath;
            marks[1] = marksHistory;
            marks[2] = marksLanguage;

            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = 0; j < countOfSetMarks; j++)
                {
                    marks[i][j] = random.Next(1, 13);
                }
            }
            return marks;
        }
        //Print
        public static void PrintMarks(string subject, int[] array)
        {
            Console.WriteLine($"\nMarks for {subject}:");
            foreach (var mark in array)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
        //Calculate average for sub-array values
        public static void PrintAverage(string subject, int[] array)
        {
            Console.WriteLine($"\nAverage for {subject}:");
            decimal sum = 0;
            foreach (var mark in array)
            {
                sum += mark;
            }

            Console.Write(Math.Round(sum / array.Length, MidpointRounding.AwayFromZero));
            Console.WriteLine();
        }
        //Calculate value to the end of the sub-array 
        public static int[] SetMark(int[] array)
        {
            int inputNumber = ValidateInput();
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = inputNumber;
            return array;
        }
        // validation for check range 1:12
        static int ValidateInput()
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 12)
            {
                return number;
            }
            else
            {
                Console.Write("\nPlease enter a valid number between 1 and 12. \nEnter number: ");
                return ValidateInput();
            }
        }


        enum MainMenu
        {
            Display_Marks, Average_Mark, Set_Mark, Exit
        }

        enum SubMenu
        {
            Back, Math, History, Language
        }


        /// <summary>
        /// Menu based enum
        /// </summary>
        /// <param name="canCancel"></param>
        /// <param name="userEnum">Enum enumeration of the user for which we build the menu</param>
        /// <param name="spacingPerLine">Number of indents between columns</param>
        /// <param name="optionsPerLine">Number of values in one column</param>
        /// <param name="startX">Number of indents on the left side of the console</param>
        /// <param name="startY">Number of indents on the upper side of the console</param>
        /// <returns></returns>
        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 18, int optionsPerLine = 2,
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

                    Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1; 
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }

    }
}

