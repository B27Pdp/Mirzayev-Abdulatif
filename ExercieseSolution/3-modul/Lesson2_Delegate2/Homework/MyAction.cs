using _3_modul.Lesson2_Delegate2.Homework.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Homework
{
    public class MyAction
    {
        Action<int> personAction = id => 
        {
            Person? user = DataBase.DataBase.GetData().Find(x => x.Id == id);
            if(user != null)
                Console.WriteLine($"id: {user.Id}\tname: {user.Name}\tage: {user.Age}\tlogin: {user.Login}\tpassword: {user.Password}");
        };

        
        public void Run()
        {
            int id = 4;

            personAction(id);
        }
        
    }
}
