using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson1_Delegate.Classwork
{
    public class MyDelagate
    {
        private int _phone;
        private string? _text, _email;

        private delegate bool SmsService(int? phone, string? message, EmailService service);
        private delegate bool EmailService(string? email, string? message);
        public void Run()
        {
            Console.Write("enter yout text: ");
            _text = Console.ReadLine();
            Console.Write("phone: ");
            string phone = Console.ReadLine();

            int.TryParse(phone, out _phone);
            EmailService mail = SendEmail;
            SmsService service = SendSms;

            bool isSend = service.Invoke(_phone, _text, SendEmail);

            
        }
        
        private bool SendSms(int? phone, string? message, EmailService service)
        {
            if(phone.HasValue && message != null)
            {
                Console.WriteLine($"Successfull:  sms: {message}, phone: {phone}");
                service.Invoke("hello@gmail.com", message);
                return true;
            }
            else Console.WriteLine($"phone number or message error, Pelase try again!");
            return false;
        }
        private bool SendEmail(string? email, string? message)
        {
            Console.WriteLine($"Successfull:  text: {message}, email: {email}");
            return true;
        }
    }
}
