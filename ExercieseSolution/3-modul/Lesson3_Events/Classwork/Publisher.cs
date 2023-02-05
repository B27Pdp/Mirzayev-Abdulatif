using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events.Classwork
{
    public class Publisher
    {
        List<(string?, string?)> list = new();

        public delegate void ClickSendSms(string phone, string message);

        public event ClickSendSms? SendSms;

        public delegate void Delegate();

        public void Run()
        {
            Console.Write("phone: ");
            string str = Console.ReadLine() ?? string.Empty;
            Console.Write("message: ");
            string str2 = Console.ReadLine() ?? string.Empty;

            SendSms?.Invoke(str, str2);
        }

        public void Getlist()
        {
            list.ForEach(x => Console.WriteLine(x));
        }

        public void AddSms(string? phone, string? message)
        {
            list.Add((phone, message));
        }

    }
}
