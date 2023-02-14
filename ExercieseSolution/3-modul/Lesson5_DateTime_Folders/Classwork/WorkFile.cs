using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_modul.Lesson5_DateTime_Folders.Classwork
{
    public class WorkFile
    {
        public void Run()
        {
            bool isActive = true;
            int choice;
            while (isActive)

            {
                Console.Clear();
                Console.Write("1.Sign in\n2.Sign up\n3.Get All\nchoose option: ");
                string? choose = Console.ReadLine();

                int.TryParse(choose, out choice );

                switch (choice)
                {
                    case 1: SignIn(); break;
                    case 2: SignUp(); break;
                    case 3: GetAll(); break;
                }
            }
        }
        private bool SignUp()
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Phone number: +(998) ");
            string? number = "+(998) " + Console.ReadLine();

            bool isTrueName = Regex.IsMatch(name, @"^[\w]+$");
            bool isTrueNumber = Regex.IsMatch(number, @".[(998)]\s*\d+");

            string path = Directory.GetCurrentDirectory();
            DirectoryInfo? directoryInfo = new DirectoryInfo(path);
            directoryInfo = directoryInfo.Parent?.Parent?.Parent;

            string currentPath = directoryInfo + "\\Lesson5_DateTime_Folders\\ClassWork\\DataBase";

            if (!(Directory.Exists(currentPath) || File.Exists(currentPath + "\\Data.txt")))
            {
                Directory.CreateDirectory(currentPath);
                File.Create(currentPath + "\\Data.txt").Close();
            }
            if (!(isTrueName && isTrueNumber)) { Console.WriteLine("Name or phone numeber is error!"); Console.ReadKey(); return false; }
            
            Person person = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                PhoneNumber = number
            };

            using (StreamWriter writer = File.AppendText(currentPath + "\\Data.txt"))
            {
                writer.WriteLine(person);
            }
            Console.WriteLine("Successfully");
            Console.ReadKey();
            return true;
        }
        private bool SignIn()
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();

            string path = Directory.GetCurrentDirectory();
            DirectoryInfo? directoryInfo = new DirectoryInfo(path);
            directoryInfo = directoryInfo.Parent?.Parent?.Parent;

            string currentPath = directoryInfo + "\\Lesson5_DateTime_Folders\\ClassWork\\DataBase";

            if (!Directory.Exists(currentPath)) { Console.WriteLine("You have not account!"); Console.ReadKey(); return false; }
            
            List<string> list = File.ReadAllLines(currentPath + "\\Data.txt").ToList();

            int userIndex = list.IndexOf($"Name: {name}");

            if (userIndex == -1) { Console.WriteLine("You have not account in our system!"); Console.ReadKey(); return false; }

            Console.WriteLine();
            for (int i = userIndex-1; i <= userIndex; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("There are your information!");
            Console.ReadKey();
            return true;
        }
        private bool GetAll()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo? directoryInfo = new(path);

            directoryInfo = directoryInfo.Parent?.Parent?.Parent;

            string currentPath = directoryInfo + "\\Lesson5_DateTime_Folders\\ClassWork\\DataBase";

            if(!Directory.Exists(currentPath)) { Console.WriteLine("We have not any user!"); Console.ReadKey(); return false; }

            List<string> listOfUser = File.ReadAllLines(currentPath + "\\Data.txt").ToList();

            Person user = new Person();
            List<Person> people = new List<Person>();

            for (int i = 0; i < listOfUser.Count; i++)
            {
                if (listOfUser[i].Contains("Id: "))
                {
                    int index = listOfUser[i].IndexOf(' ')+1;
                    user.Id = listOfUser[i].Substring(index, listOfUser[i].Length - index);
                }
                else if (listOfUser[i].Contains("Name: "))
                {
                    int index = listOfUser[i].IndexOf(' ')+1;
                    user.Name = listOfUser[i].Substring(index, listOfUser[i].Length - index);
                }
                else if (listOfUser[i].Contains("PhoneNumber: "))
                {
                    int index = listOfUser[i].IndexOf(' ')+1;
                    user.PhoneNumber = listOfUser[i].Substring(index, listOfUser[i].Length - index);
                }
                else
                {
                    people.Add(user);
                    user = new Person();
                }
            }

            Console.WriteLine();

            foreach (var item in people)
            {
                Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nPhone number: {item.PhoneNumber}\n");
            }
            Console.WriteLine("Successfully");
            Console.ReadKey();
            return true;
        }
    }
}
