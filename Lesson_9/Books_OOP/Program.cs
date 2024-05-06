
namespace Books_OOP
{
    internal class Program
    {
        #region Simple variant with static data
        //static void Main(string[] args)
        //{
        //    Book book1 = new Book
        //    {
        //        Title = "Dune",
        //        Author = "Frank Herbert",
        //        Year = 1965,
        //        Pages = 501,
        //    };
        //    Book book2 = new Book
        //    {
        //        Title = "1984",
        //        Author = "George Orwell",
        //        Year = 1949,
        //        Pages = 350,
        //    };
        //    book1.DisplayInfo();
        //    book1.IsThick();

        //    book2.DisplayInfo();
        //    book2.IsThick();
        //}

        #endregion
        #region Variant with adding books via objects array with type Book
        static void Main(string[] args)
        {
            Book[] books = GetBooks();

            DisplayAllBooks(books);
        }
        // Get book info from user until rejecting continue 
        static Book[] GetBooks()
        {
            // array of Book type objects
            Book[] books = new Book[0];
            string answer;

            // loop for adding
            do
            {
                Book book = GetBookInformation();
                books = SaveBook(books, book);

                Console.WriteLine("Do you want to add one more book? (Y/N): ");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() == "y");

            return books;
        }
        // Get info from user about properties and return class instance  
        static Book GetBookInformation()
        {
            Console.WriteLine("Add info about book:");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            // used for year to, in cause decided that user like books which are wriiten only in our era)))
            Console.Write("Year: ");
            int year = ValidateInput("Please enter a valid year greater than 0: ");

            Console.Write("Count of pages: ");
            int pages = ValidateInput("Please enter a valid number of pages greater than 0: ");

            return new Book
            {
                Title = title,
                Author = author,
                Year = year,
                Pages = pages
            };
        }
        // validation for int properties  
        static int ValidateInput(string errorMessage)
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
        //Method which clear last line on the Console
        static void ClearLastLine()
        {
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.WriteLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
        // add book object to the Book books array
        public static Book[] SaveBook(Book[] array, Book newBook)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = newBook;
            return array;
        }
        // Print info about all books and about their thicking) 
        static void DisplayAllBooks(Book[] array)
        {
            Console.Clear();
            Console.WriteLine("Info about your books:");
            foreach (var book in array)
            {
                book.DisplayInfo();
                book.IsThick();
            }
        }
        #endregion
    }
}
