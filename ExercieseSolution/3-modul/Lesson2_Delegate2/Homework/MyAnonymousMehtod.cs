using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_modul.Lesson2_Delegate2.Homework.DataBase;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3_modul.Lesson2_Delegate2.Homework
{
    public class MyAnonymousMehtod
    {
        private delegate void GetAllUserDelegate(List<Person> data);
        private delegate void GetUserDelegate();

        GetAllUserDelegate del = delegate (List<Person> db)
        {
            foreach (Person user in db)
                Console.WriteLine($"id: {user.Id}\tname: {user.Name}\tage: {user.Age}\tlogin: {user.Login}\tpassword: {user.Password}");
        };

        GetUserDelegate user = delegate ()
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("create login: ");
            string? login = Console.ReadLine();
            Console.Write("create password: ");
            string? password = Console.ReadLine();
            Person person = new()
            {
                Id = DataBase.DataBase._id++,
                Name = name,
                Age = age,
                Login = login,
                Password = password
            };

            DataBase.DataBase.PutData(person);
        };
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("1.Add user\n2.Show all users\nchoose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: user.Invoke(); break;
                    case 2: del.Invoke(DataBase.DataBase.GetData()); break;
                    default: break;
                }
                Console.ReadKey();
            }
        }
    }
}
