using Sms.Domain;


namespace Sms.DataBase
{
    public class DataBase
    {
        public static List<UserAccount>? Users = new()
        {
            new UserAccount() {Id = 1, Name = "Admin", Login = "Admin", Password = "Admin", PhoneNumber = "1010"},
            new UserAccount() {Id = 2, Name = "Ali",   Login = "Uzbek", Password = "7777",  PhoneNumber = "+998901502004"}
        };

        public static List<ChatInfo> Data = new();


        public void Run()
        {
            DelegateHandler?.Invoke();
        }

        public delegate void Delegate();

        public event Delegate? DelegateHandler;
    }
}
