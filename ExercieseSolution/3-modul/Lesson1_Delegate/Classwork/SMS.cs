using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson1_Delegate.Classwork
{
    public class SMS
    {
        //delegate int SMS_Delegate(int phone);
        //delegate string SMS_Delegate2(string message);
        //delegate SMS_Delegate SMS_Delegate3(SMS_Delegate s);
        private int _phone;
        public int GetPhone()
        {
            return _phone;
        }
        public bool Sender(string sms, int phone)
        {
            _phone = phone;
            Console.WriteLine($"sms: {sms}\tphone: {phone}");
            return true;
        }
    }
}
