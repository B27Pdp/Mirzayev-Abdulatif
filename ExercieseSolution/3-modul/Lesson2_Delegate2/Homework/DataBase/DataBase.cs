using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_modul.Lesson2_Delegate2.Homework.States;

namespace _3_modul.Lesson2_Delegate2.Homework.DataBase
{
    public class DataBase
    {
        public static int _id = 5;
        private static List<Person> data = new()
        {
            new Person() {Id = 1, Name = "Birkishi",  Age = 45,  Login = "Admin", Password = "Admin", Status = Status.Active},
            new Person() {Id = 2, Name = "Ikkikishi", Age = 20,  Login = "132",   Password = "956",   Status = Status.Banned},
            new Person() {Id = 3, Name = "Ushakishi", Age = 11,  Login = "123",   Password = "264",   Status = Status.Active},
            new Person() {Id = 4, Name = "Tortkishi", Age = 19,  Login = "654",   Password = "aaa",   Status = Status.Banned},
            new Person() {Id = 5, Name = "Palon",     Age = 30,  Login = "9897",  Password = "4565",  Status = Status.Active},
            new Person() {Id = 6, Name = "Bobo",      Age = 84,  Login = "2222",  Password = "1111",  Status = Status.Active},
        };

        public static Func<List<Person>> GetData = () => data;

        public static Action<Person> PutData = user => 
        { 
            user.Status = Status.Active;
            data.Add(user);
        };

    }
}
