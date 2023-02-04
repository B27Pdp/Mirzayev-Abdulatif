using _3_modul.Lesson2_Delegate2.Homework.DataBase;
using _3_modul.Lesson2_Delegate2.Homework.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Homework
{
    public class MyFunction
    {
        Func<Person, bool> predicate = user => { return user.Status == Status.Active; };

        Func<Person, bool> predic = user => { return user.Status != Status.Active; };

        public void Run()
        {
            var db = DataBase.DataBase.GetData().Where(predicate);
            foreach (Person user in db)
                Console.WriteLine($"id: {user.Id}\tname: {user.Name}\tage: {user.Age}\tlogin: {user.Login}\tpassword: {user.Password}");
            Console.WriteLine("\n");

            db = DataBase.DataBase.GetData().Where(predic);
            foreach (Person user in db)
                Console.WriteLine($"id: {user.Id}\tname: {user.Name}\tage: {user.Age}\tlogin: {user.Login}\tpassword: {user.Password}");
        }
    }
}
