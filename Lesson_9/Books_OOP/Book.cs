

namespace Books_OOP
{
    internal class Book
    {
        /// <summary>
        /// Not required fields in this case if they are commneted, automaticly uses auto-implemeted properties below.
        /// REMINDER! ask teacher about memory for fields and cases with auto-implemeted properties and validation for setters
        /// </summary>
        //private string _title, _author;
        //private int _year, _pages;

        public string Title { get; set;}
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }


        // Display properties for class instance 
        public void DisplayInfo()
        {
            Console.WriteLine(
                $"Title: {Title}\n" +
                $"Author: {Author}\n" +
                $"Year: {Year}\n" +
                $"Pages: {Pages}");
        }
        // Checks and display info about the thickness of the book
        public void IsThick() 
        {
            Console.WriteLine($"This book is {(Pages > 500 ? "" : "not so")} thick\n");
        }
    }
}
