using _3_modul.Lesson3_Events.Classwork;
using _3_modul.Lesson3_Events.Homework;
using _3_modul.Lesson3_Events.Homework.Card;
using _3_modul.Lesson3_Events.Homework.Card.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events
{
    public class Lesson3
    {
        public static void Run()
        {
            /**
             * 
             * 
             
            Card Humo = new(CardType.Humo)
            {
                Id = 1,
                Balance = 456,
                Owner = "Palonchi"
            };

            Card Visa = new(CardType.Visa)
            {
                Id = 2,
                Balance = 789,
                Owner = "Palon",
            };

            Humo.Transaction(Visa);
            *
            *
            **/

            Task2Run obj = new Task2Run();
            obj.Run();

            

        }
    }
}
