using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events.Homework
{
    public class Task2Run
    {
        public void Run()
        {
            task2 task2 = new task2();
            task2.OnEvenNumberFound += CoupleNumberFound;

            task2.ListOfElement = new() { 11, 21, 7, 9, 22 }; ;

        }

        private void CoupleNumberFound(object sender, EventArgs e)
        {
            Console.WriteLine("Couple Numeber is found!");
        }
    }
}
