using System.Text.RegularExpressions;

namespace _3_modul.Lesson4_Regex.Homework
{
    public class RegularExpressions
    {
        public static void Run()
        {

            string[] str = { "901502004", "90-150-20-04", "90 150 20 04", "933 456 20 20" };

            foreach (string item in str)
            {
                Console.WriteLine(IsValidNumber(item));
            }

        }
        public static bool IsValidNumber(string str)
        {
            string pattern = @"^([0-9]{9})|([0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2})|([0-9]{2}\s[0-9]{3}\s[0-9]{2}\s[0-9]{2})$";

            return Regex.IsMatch(str, pattern);

        }
    }
}
