namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _password = "Admin";
            string _login = "Admin";
            bool isActive = true;
            decimal balance = 150000;


            while (isActive)
            {
                Console.Clear();
                Console.Write("Login: ");
                string login = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (login == _login && password == _password)
                {
                    int choice;
                    bool isTrue = true;
                    while (isTrue)
                    {
                        Console.Clear();
                        string choose = SecondMenu();
                        int.TryParse(choose, out choice);

                        switch (choice)
                        {
                            case 1: Withdraw(ref balance); break;

                            case 2: Deposit(ref balance); break;

                            case 3:
                                Console.WriteLine($"Current balance: {balance}");
                                Console.ReadKey(); break;
                            case 4: isTrue = false; isActive = false; break;
                            default: Console.WriteLine("Error!"); Console.ReadKey(); break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Something is error!!!");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Thank you for using our ATM system!");

        }

        static string SecondMenu()
        {
            Console.Write("1.Withdraw\n2.Deposit\n3.Balance\n4.Exit\nchoose option: ");
            string choose = Console.ReadLine();

            return choose;
        }

        static void Withdraw(ref decimal balance)
        {
            Console.Write("enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Successful withdrawed...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please deposit enough money!!!");
                Console.ReadKey();
            }

        }

        static void Deposit(ref decimal balance)
        {
            Console.Write("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Successful deposited...");
            Console.ReadKey();
        }

    }
}