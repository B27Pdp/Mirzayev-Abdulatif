using Person.Domain;
using System.Text.RegularExpressions;

namespace Person
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
                Console.Write("1.Sigin in\n2.Sign up\nchoose option: ");
                string? choose = Console.ReadLine();
                int.TryParse(choose, out choice);

                switch (choice)
                {
                    case 1: SignIn(); break;
                    case 2: SignUp(); break;
                    default: break;
                }
            }
        }
        static bool SignIn()
        {
            Console.Write("Login: ");
            string? login = Console.ReadLine();

            string path = Directory.GetCurrentDirectory().ToString();
            DirectoryInfo? directoryInfo = new DirectoryInfo(path);

            directoryInfo = directoryInfo.Parent?.Parent?.Parent;
            string pathOfFile = directoryInfo + $"\\DataBase\\{login}.txt";

            if (!File.Exists(pathOfFile))
            {
                Console.WriteLine("We have not like this account");
                Console.ReadKey();
                return false;
            }
            
            FileInfo fileInfo = new FileInfo(pathOfFile);

            Console.Write("Password: ");
            string? password = Console.ReadLine();

            List<string> list = File.ReadAllLines(pathOfFile).ToList();

            var isValidPassword = list.Find(a => a == $"Password: {password}");

            if(isValidPassword == null)
            {
                Console.WriteLine("Password is incorrect!");
                Console.ReadKey();
                return false;
            }
            Console.WriteLine();
            using (StreamReader reader = fileInfo.OpenText())
            {
                var text = "";
                while ((text = reader.ReadLine()) != null) 
                {
                    Console.WriteLine(text);
                }
            }
            Console.ReadKey();
            return true;
        }
        static bool SignUp()
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Create login: ");
            string? login = Console.ReadLine();

            string path = Directory.GetCurrentDirectory().ToString();
            DirectoryInfo? directoryInfo = new DirectoryInfo(path);
            directoryInfo = directoryInfo.Parent?.Parent?.Parent;

            if (File.Exists(directoryInfo?.FullName + $"\\DataBase\\{login}.txt"))
            {
                Console.WriteLine("This user name is already exists...");
                Console.ReadKey();
                return false;
            }

            Console.Write("Create password: ");
            string? password = Console.ReadLine();

            if (name?.Length == 0 || login?.Length == 0 || password?.Length == 0) { Console.WriteLine("somthing is error"); Console.ReadKey(); return false; }

            

            bool isValidPassword = Regex.IsMatch(password, "([A-Z]+|[a-z]+|[0-9]+){8,}");

            if (!isValidPassword) { Console.WriteLine("Please enter stronger password..."); Console.ReadKey(); return false; }
            
            Human human = new()
            {
                Id = 2,
                Name = name,
                Login = login,
                Password = password
            };

            FileInfo fileInfo = new FileInfo(directoryInfo?.FullName + $"\\DataBase\\{login}.txt");

            using(StreamWriter writer = fileInfo.CreateText()) 
            {
                writer.WriteLine(human);
            }
            Console.WriteLine("Successfully rigistred");
            Console.ReadKey();
            return true;
        }
    }
}

