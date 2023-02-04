using _3_modul.Lesson2_Delegate2.Homework.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Homework
{
    public class MyLambdaExpression
    {
        public delegate string? GetName(int id);
        public delegate void Delete(int id);
        public void Run()
        {
            GetName lmbd = id => 
            { 
                string? user = DataBase.DataBase.GetData()?.Find(a => a.Id == id)?.Name;
                return user;
            };
            string? s = lmbd.Invoke(3);
            Console.WriteLine(s);

            Delete delete = id =>
            {
                var user = DataBase.DataBase.GetData();
                user.Remove(user.Find(a => a.Id == id));
            };
            delete.Invoke(3);
        }
    }
}
