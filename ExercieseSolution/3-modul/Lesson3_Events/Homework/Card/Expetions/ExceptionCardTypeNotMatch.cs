using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events.Homework.Card.Expetions
{
    [Serializable]
    public class ExceptionCardTypeNotMatch : Exception
    {
        public ExceptionCardTypeNotMatch(string message = "Kartalar xolati mos bo'lmagan holat") : base(message) { }
        
    }
}
