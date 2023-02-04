using _3_modul.Lesson2_Delegate2.Homework.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Homework
{
    public class MyPredicates
    {
        public delegate void Delegate();

        Predicate<Person> predicate = user =>
        {
            if (user.Age > 17) return true;
            return false;
        };
        Predicate<Person> filter = user => 
        {
            if(user.Password.Length > 3) return true;
            return false;
        };
        public void Run()
        {
            var data = DataBase.DataBase.GetData().FindAll(predicate);
            var data1 = DataBase.DataBase.GetData().FindAll(filter);
            Console.WriteLine("Users which are age is upper 17: \n");
            foreach (Person user in data)
            {
                Console.WriteLine($"id: {user.Id}\tname: {user.Name}\tage: {user.Age}\tlogin: {user.Login}\tpassword: {user.Password}");
            }
            Console.WriteLine("\nUsers which are password length upper 3: \n");
            foreach (Person user in data1)
            {
                Console.WriteLine($"id: {user.Id}\tname: {user.Name}\tage: {user.Age}\tlogin: {user.Login}\tpassword: {user.Password}");
            }
        }
    }
}
