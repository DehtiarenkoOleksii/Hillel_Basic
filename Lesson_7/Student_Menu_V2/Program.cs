

namespace Student_Menu_V2
{
    internal class Program
    {
        // global variable
        static int[][] marks;
        static void Main(string[] args)
        {
            // initialize array of arrays with random length and random values
            marks = InitializeData();
            OpenMenu();

        }
        // Main menu
        static void OpenMenu()
        {
            while (true)
            {
                int mainInput = MultipleChoice(true, new MainMenu());

                switch ((MainMenu)mainInput)
                {
                    case MainMenu.Display_Marks:
                    case MainMenu.Average_Mark:
                    case MainMenu.Set_Mark:
                        {
                            // Open sub-menu with sujects. What sub-menu will do , it depemds on previous choice
                            OpenSubMenu((MainMenu)mainInput);
                            break;
                        }
                    case MainMenu.Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
                // Need to clear consile after operation
                Console.Clear();
            }
        }
        static void OpenSubMenu(MainMenu menu)
        {
            while (true)
            {
                // Display sub-menu and wait for user actions
                int subInput = MultipleChoice(true, new SubMenu());

                // Обработка выбора пользователя
                switch ((SubMenu)subInput)
                {
                    case SubMenu.Back:
                        {
                            // go to MainMenu -> an we in OpenMenu method again)
                            return;
                        }
                    case SubMenu.Math:
                    case SubMenu.History:
                    case SubMenu.Language:
                        {

                            // handling for user choice
                            if (menu == MainMenu.Display_Marks)
                            {
                                PrintMarks(((SubMenu)subInput).ToString(), marks[subInput - 1]);
                            }
                            else if (menu == MainMenu.Average_Mark)
                            {
                                PrintAverage(((SubMenu)subInput).ToString(), marks[subInput - 1]);
                            }
                            else if (menu == MainMenu.Set_Mark)
                            {
                                Console.Write($"\nEnter number for {((SubMenu)subInput).ToString()}: ");
                                marks[subInput - 1] = SetMark(marks[subInput - 1]);
                            }
                            break;
                        }
                    default:
                        break;
                }
                // Delay
                Console.ReadLine();
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
        //Add value to the end of the sub-array 
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

