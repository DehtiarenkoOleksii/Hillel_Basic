namespace Bank_System
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // array for all types accounts
            BankAccount[] accounts = new BankAccount[0] ;
            OpenMenu(ref accounts);
        }

        // Interactive main menu
        static void OpenMenu(ref BankAccount[] accounts)
        {
            while (true)
            {
                int choice = MenuHelper.MultipleChoice(false, new MenuOptions());

                switch ((MenuOptions)choice)
                {
                    case MenuOptions.CreateSavingsAccount:
                        {
                            CreateSavingsAccount(ref accounts);
                            break;
                        }
                    case MenuOptions.CreateCheckingAccount:
                        {
                            CreateCheckingAccount(ref accounts);
                            break;
                        }
                    case MenuOptions.Deposit:
                        {
                            Deposit(accounts);
                            break;
                        }
                    case MenuOptions.Withdraw:
                        {
                            Withdraw(accounts);
                            break;
                        }
                    case MenuOptions.DisplayAccountInfo:
                        {
                            DisplayAccountInfo(accounts);
                            break;
                        }
                    case MenuOptions.Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

        // Fulfill data for new Saving acc
        static void CreateSavingsAccount(ref BankAccount[] accounts)
        {
            Console.Clear();
            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            double balance = (double)ValidateInput();
            Console.Write("Enter interest rate (as a decimal): ");
            double interestRate = (double)ValidateInput();

            BankAccount newAccount = new SavingsAccount(name, balance, interestRate);
            accounts = AddAccount(accounts, newAccount);
        }

        // Fulfill data for new Checking acc
        static void CreateCheckingAccount(ref BankAccount[] accounts)
        {
            Console.Clear();
            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            double balance = (double)ValidateInput();
            Console.Write("Enter overdraft limit: ");
            double overdraftLimit = (double)ValidateInput();

            BankAccount newAccount = new CheckingAccount(name, balance, overdraftLimit);
            accounts = AddAccount(accounts, newAccount);
        }

        // Add new account to array
        public static BankAccount[] AddAccount(BankAccount[] array, BankAccount newAccount)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = newAccount;
            return array;
        }

        // Validation until get postive number with clearing lines
        public static decimal ValidateInput()
        {
            decimal number;
            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out number) || number <= 0)
                {
                    ClearLastLine();
                    Console.Write("Please enter a valid number greater than 0: ");
                }
                else
                {
                    
                    number = Math.Round(number, 2);
                    break;
                }
            }

            return number;
        }

        //clear last inputed line(useful for validation)
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        // Method for navigation in already created accounts with some validation
        static BankAccount SelectAccount(BankAccount[] accounts)
        {
            // check that we have at least one account
            if (accounts.Length == 0)
            {
                Console.WriteLine("No accounts available.");
                Console.ReadLine();
                return null;
            }
            // display accounts array
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"{i}: {accounts[i].DisplayAccountInfo()}");
            }

            // Validation for selecting account
            // I've thought about extracting it on separate method but not decided it in cause in my mind it's more logic here
            while (true)
            {
                Console.Write("Select account by number: ");
                string input = Console.ReadLine();
                try
                {
                    int selectedIndex = int.Parse(input);
                    if (selectedIndex >= 0 && selectedIndex < accounts.Length)
                    {
                        return accounts[selectedIndex];
                    }
                    else
                    {
                        ClearLastLine();
                        Console.WriteLine("Invalid selection. Please enter a valid number.");
                    }
                }
                catch (FormatException)
                {
                    ClearLastLine();
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        // Print all accounts/selected account
        static void DisplayAccountInfo(BankAccount[] accounts)
        {
            Console.Clear();
            // check that we have at least one account
            BankAccount account = SelectAccount(accounts);
            if (account == null) return;

            Console.WriteLine(account.DisplayAccountInfo());
            Console.ReadLine();
        }

        // increase amount on selected account
        static void Deposit(BankAccount[] accounts)
        {
            Console.Clear();
            // check that we have at least one account
            BankAccount account = SelectAccount(accounts);
            if (account == null) return;

            Console.Write("Enter amount to deposit: ");
            double amount = (double)ValidateInput();
            account.Deposit(amount);
            Console.WriteLine(account.DisplayAccountInfo());
            Console.ReadKey();
        }

        // decrease amount on selected account if it's possible
        static void Withdraw(BankAccount[] accounts)
        {
            Console.Clear();
            // check that we have at least on account
            BankAccount account = SelectAccount(accounts);
            if (account == null) return;

            Console.Write("Enter amount to withdraw: ");
            double amount = (double)ValidateInput();
            account.Withdraw(amount);
            Console.WriteLine(account.DisplayAccountInfo());
            Console.ReadKey();
        }

    }

}


