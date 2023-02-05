using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events.Homework.Card.Expetions
{
    [Serializable]
    public class ExceptionNotEnoughMoney : Exception
    {
        public ExceptionNotEnoughMoney(string message = "Pul yetarli bo'lmagan xolat") : base(message) { }
    }
}
