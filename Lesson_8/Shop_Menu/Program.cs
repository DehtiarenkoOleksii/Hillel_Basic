using System;

namespace Shop_Menu
{
    internal class Program
    {
        // global Tuple array, used decimal 
        static (string, decimal)[][] goods;
        static void Main(string[] args)
        {
            goods = InitializeData();

            OpenMenu();
        }
        // Interactive main menu
        static void OpenMenu()
        {
            while (true)
            {
                int mainInput = MultipleChoice(true, new MainMenu());

                switch ((MainMenu)mainInput)
                {
                    case MainMenu.Food:
                    case MainMenu.Clothing:
                    case MainMenu.Electronics:
                    case MainMenu.Books:
                        {
                            // add name and price product to cart depemd on selected category
                            AddProduct((MainMenu)mainInput);
                            break;
                        }
                    case MainMenu.Cart:
                        {
                            // display gods with their category and price, display total
                            DisplayCart();
                            break;
                        }
                        
                    case MainMenu.Finish:
                        {
                            // display cart and finish program
                            DisplayCart();
                            return;
                        }

                        
                    default:
                        break;
                }

                // Need to clear consile after operation
                Console.Clear();

            }
        }
        public static (string, decimal)[][] InitializeData()
        {

            (string, decimal)[] Food = new (string, decimal)[] { };
            (string, decimal)[] Clothing = new (string, decimal)[] { };
            (string, decimal)[] Electronics = new (string, decimal)[] { };
            (string, decimal)[] Books = new (string, decimal)[] { };
            (string, decimal)[][] goods = new (string, decimal)[4][];
            goods[0] = Food;
            goods[1] = Clothing;
            goods[2] = Electronics;
            goods[3] = Books;

            return goods;
        }
        // Count total um of goods ( will be 0 on start)
        public static void CountCost()
        {
            decimal totalSum = 0;
            foreach (var array in goods)
            {
                foreach (var element in array)
                {
                    totalSum += element.Item2;
                }
            }

            Console.WriteLine("Total: $" + totalSum);
        }
        // Validation until get postive number with clearing lines
        public static decimal ValidateInput()
        {
            decimal number;
            while (true)
            {
                Console.Write("Enter number: ");
                if (!decimal.TryParse(Console.ReadLine(), out number) || number <= 0)
                {
                    ClearLastLine();
                    Console.Write("Please enter a valid number greater than 0.");
                   
                }
                else
                {
                    break; 
                }
            }

            return number;
        }
        // clear last inputed line ( useful for validation)
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        // add data to the tuple array
        public static (string, decimal)[] AddGood((string, decimal)[] array, (string, decimal) newItem)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = newItem;
            return array;
        }
        // get unput data from user for adding 
        public static void AddProduct(MainMenu category)
        {
            int categoryIndex = (int)category;
            Console.WriteLine($"\nEnter the name for {category}:");
            string inputName = Console.ReadLine();
            Console.WriteLine($"\nEnter the price for {inputName}");
            decimal inputPrice = ValidateInput();

            goods[categoryIndex] = AddGood(goods[categoryIndex], (inputName, inputPrice));
        }

        public static void DisplayCart()
        {
            Console.WriteLine("\nCart contents:");
            for (int i = 0; i < goods.Length; i++)
            {
                foreach (var item in goods[i])
                {
                    Console.WriteLine($"{((MainMenu)i)}: {item.Item1} - {item.Item2}");
                }
            }
            CountCost();
            Console.ReadKey();
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
                CountCost(); // Need for always showing sum
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
