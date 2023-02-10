using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex.Classwork
{
    public class Mafia
    {
        public delegate bool EventBool<T>(object? obj, T order);
        public delegate bool AnotherOrder(object? obj, EventArgs eventArgs);

        public EventBool<AnotherOrder> Order;

        AnotherOrder? inDel;
        public void Run()
        {
            MafiaTeam mafiaTeam = new MafiaTeam();

            inDel += mafiaTeam.First;
            //OrderOfMafia += mafiaTeam.Second;
            inDel += mafiaTeam.Third;

            Order?.Invoke(this, inDel);
        }

        public void GetAnswer()
        {

        }
    }
}
