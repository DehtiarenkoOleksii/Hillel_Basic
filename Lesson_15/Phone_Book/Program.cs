namespace Phone_Book
{
    class Program
    {
        // Dictionary to store contacts, where key is the name and value is the phone number.
        static Dictionary<string, string> contacts = new Dictionary<string, string>();

        static void Main()
        {
            RunMenu();
        }

        static void RunMenu()
        {
            while (true)
            {
                Console.WriteLine("Choose an action:");
                int choice = MenuHelper.MultipleChoice(true, new MenuOption());

                switch ((MenuOption)choice)
                {
                    case MenuOption.AddContact:
                        AddContact();
                        break;
                    case MenuOption.DeleteContact:
                        DeleteContact();
                        break;
                    case MenuOption.UpdateContact:
                        UpdateContact();
                        break;
                    case MenuOption.SearchContact:
                        SearchContact();
                        break;
                    case MenuOption.ListContacts:
                        ListContacts();
                        break;
                    case MenuOption.Exit:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Add  new contact to the phone book
        static void AddContact()
        {
            Console.Clear();
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine("A contact with this name already exists.");
                return;
            }

            Console.WriteLine("Enter the phone number:");
            string phone = Helper.ReadPhoneNumber();

            contacts.Add(name, phone);
            Console.WriteLine("Contact added.");
            Console.ReadKey();
        }

        // Delete contact from the phone book
        static void DeleteContact()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the contact to delete:");
            string name = Console.ReadLine();

            if (contacts.Remove(name))
            {
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("No contact found with this name.");
            }
            Console.ReadKey();
        }

        // Update contact in the phone book
        static void UpdateContact()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the contact to update:");
            string name = Console.ReadLine();

            if (contacts.ContainsKey(name))
            {
                Console.WriteLine("Enter the new phone number:");
                string newPhone = Helper.ReadPhoneNumber();
                contacts[name] = newPhone;
                Console.WriteLine("Phone number updated.");
            }
            else
            {
                Console.WriteLine("No contact found with this name.");
            }
            Console.ReadKey();
        }

        // Search contact in the phone book
        static void SearchContact()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the contact to search for:");
            string name = Console.ReadLine();

            if (contacts.TryGetValue(name, out string phone))
            {
                Console.WriteLine($"Name: {name}, Phone number: {phone}");
            }
            else
            {
                Console.WriteLine("No contact found with this name.");
            }
            Console.ReadKey();
        }

        static void ListContacts()
        {
            Console.Clear();
            Console.WriteLine("List of contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Key}, Phone number: {contact.Value}");
            }
            Console.ReadKey();
        }

    }
}
