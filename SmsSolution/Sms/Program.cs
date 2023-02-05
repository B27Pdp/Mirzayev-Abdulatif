using Sms.Domain;
using System.Reflection.Metadata;

namespace Sms
{
    class Program
    {

        static void Main(string[] args)
        {
            bool isActive = true;
            int choice;

            while (isActive)
            {
                Console.Clear();
                Console.WriteLine("         Welcome our Chat");
                Console.Write("1.Sign in\n2.Sign up\n3.Exit\nchoose option: ");
                string? s = Console.ReadLine();
                int.TryParse(s, out choice);

                switch (choice)
                {
                    case 1:
                        {
                            var sign = SignIn();
                            if (sign != null) SMSMenu(sign);

                        }
                        break;
                    case 2:
                        {
                            var user = SignUp();
                            if (user != null) SMSMenu(user);
                        }
                        break;
                    case 3: isActive = false; break;
                    default: break;
                }
            }
        }

        static UserAccount? SignIn()
        {
            Console.Clear();
            Console.Write("enter login: ");
            string? login = Console.ReadLine();
            Console.Write("enter password: ");
            string? password = Console.ReadLine();

            UserAccount? user = DataBase.DataBase.Users?.Find(x => x.Login == login);

            if (user != null)
            {
                if (user.Password == password)
                {
                    return user;
                }
                else
                {
                    Console.WriteLine("Error password!");
                    Print();
                }
            }
            else
            {
                Console.WriteLine("Not found like this user");
                Print();
            }
            return null;
        }

        static UserAccount? SignUp()
        {

            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            Console.Write("Enter your phone number: +(998) ");
            string? phone = "+998" + Console.ReadLine();
            Console.Write("Create login: ");
            string? login = Console.ReadLine();
            Console.Write("Create password: ");
            string? password = Console.ReadLine();

            int size = DataBase.DataBase.Users?.Count - 1 ?? -1;

            UserAccount user = new()
            {
                Id = 1 + DataBase.DataBase.Users[size].Id,
                Name = name,
                PhoneNumber = phone,
                Login = login,
                Password = password,
            };
            Console.WriteLine(user.Id);
            Console.WriteLine("Successfully registred!");

            #region EventForAddData
            DataBase.DataBase data = new();
            data.DelegateHandler += user.Add;
            data.Run();
            data.DelegateHandler -= user.Add;
            #endregion

            Print();
            return user;
        }

        static void SMSMenu(UserAccount user)
        {
            bool isActive = true;
            int choice;

            while (isActive)
            {
                Console.Clear();
                Console.Write("1.My Contact\n2.Add Contact\n3.Exit\nchoose option: ");
                string? option = Console.ReadLine();
                int.TryParse(option, out choice);

                switch (choice)
                {
                    case 1: MyContact(user); Print(); break;
                    case 2: AddContact(user);  break;
                    case 3: isActive = false; break;
                    default: Console.Clear(); break;
                }
            }
        }

        static void AddContact(UserAccount user)
        {
            bool isActive = true;
            var users = DataBase.DataBase.Users;
            while (isActive)
            {
                Console.Clear();
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Login == user.Login) continue;

                    Console.WriteLine(i + 1 + "." + users[i].Login);
                }
                Console.Write("\n0.Back\nWrite one login to add your contact: ");
                string? contact = Console.ReadLine();
                if (contact == "0") isActive = false;
                else
                {
                    UserAccount? friend = DataBase.DataBase.Users?.Find(b => b.Login == contact);
                    if (friend != null)
                    {
                        ChatInfo chat = new()
                        {
                            Login = user.Login,
                            User = friend,
                            Text = new List<string> { "No message here" }
                        };
                        DataBase.DataBase.Data.Add(chat);
                        Console.WriteLine("Successfully added friend");
                    }
                    else
                    {
                        Console.WriteLine("friend not found");
                    }
                    Print();
                }
            }
        }

        static void MyContact(UserAccount user)
        {
            bool isActive = true;

            while (isActive)
            {
                var list = DataBase.DataBase.Data;
                if (list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i+1} - {list[i]?.User?.Login}");
                    }
                    Console.Write("\n0.Back\nWrite one to chatting: ");
                    string? option = Console.ReadLine();

                    var receiver = DataBase.DataBase.Data.Find(a => a.User?.Login == option);

                    if (receiver != null)
                    {
                        bool isTrue = true;
                        
                        while (isTrue)
                        {
                            List<string>? text = DataBase.DataBase.Data.Find(a => a.User?.Login == option)?.Text;

                            for (int i = 0; i < text?.Count; i++)
                            {
                                Console.WriteLine(text[i]);
                            }

                            Console.Write("\n0.Back\nWrite message here: ");
                            string? message = Console.ReadLine();

                            if (message != "0")
                            {
                                string str = $"                 {DateTime.Now.ToString("MM/dd/yyyy H:mm")}\n{message}";

                                ChatInfo chat = new()
                                {
                                    Login = user.Login,
                                    User = DataBase.DataBase.Users?.Find(a => a.Login == receiver?.User?.Login)
                                };

                                Console.WriteLine("Successfull messaged!");
                            }
                            else if (message == "0")
                            {
                                isTrue = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You have not any friends yet!");
                    isActive = false;
                }



            }
        }












        static void Print()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void PrintUserInfo(UserAccount userAccount)
        {
            Console.Clear();
            Console.WriteLine($"Name: {userAccount.Name}\nPhone: {userAccount.PhoneNumber}\n" +
                $"Login: {userAccount.Login}\nPassword: {userAccount.Password}");
            Print();
        }

    }
}



