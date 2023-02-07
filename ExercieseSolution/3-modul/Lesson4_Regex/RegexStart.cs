using _3_modul.Lesson4_Regex.Homework;
using _3_modul.Lesson4_Regex.Homework.Josus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex
{
    public class RegexStart
    {
        public static void Run()
        {
            //RegularExpressions.Run();
            //Task1.IsValid(new string[] {"Samandar", "Abdulatif", "Salom"});
            //Task1.IsNumber("df4654asf4df645f465465fd4");

            Boss boss = new Boss();
            Agent agent = new Agent();

            boss.OnClick += agent.GetOrder;
            agent.AgentReceived += boss.IsFinished;
            boss.Mission();
            

        }
    }
}
