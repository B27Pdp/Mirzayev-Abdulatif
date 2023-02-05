namespace _3_modul.Lesson3_Events.Classwork
{
    public class Subscriber
    {
        List<(string?, string?)> list = new();

        public event Publisher.ClickSendSms? SendSmsOfSubscriber;

        public void Run()
        {
            Console.Write("phone: ");
            string str = Console.ReadLine() ?? string.Empty;
            Console.Write("message: ");
            string str2 = Console.ReadLine() ?? string.Empty;

            SendSmsOfSubscriber?.Invoke(str, str2);
        }

        public void GetSms()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void AddSms(string? phone, string? message)
        {
            list.Add((phone, message));
        }
    }
}
