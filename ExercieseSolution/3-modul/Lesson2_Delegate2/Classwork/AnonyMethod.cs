namespace _3_modul.Lesson2_Delegate2.Classwork
{
    public class AnonyMethod
    {
        public delegate void AnonMethod(int age, string name);
        public static void Run()
        {
            AnonMethod method = delegate (int age, string name)
            {
                Console.WriteLine($"age: {age}\tname: {name}");
            };
            method.Invoke(5, "Hello");
        }
    }
}
