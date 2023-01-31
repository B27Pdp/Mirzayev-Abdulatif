namespace Exerciese.Lesson_Indexer.Homework
{
    public class ListInUse<T>
    {
        MyGenericList<T> list = new();

        public void Run()
        {
            //Console.WriteLine(typeof(string).ToString().ToLower()); ;

            Console.Clear();
            bool isActive = true;
            int choose;
            string choice = string.Empty;

            while (isActive)
            {
                Console.Clear();
                Console.Write("1.Qo'shish\n2.O'chrish\n3.O'zgartirish\n" +
                    "4.Ekranga chiqarish(By index)\n5.Barcha elementni ko'rish\n0.Back\nChoose option: ");
                choice = Console.ReadLine();
                int.TryParse(choice, out choose);

                switch (choose)
                {
                    case 0: isActive = false; break;
                    case 1: Adder(); break;
                    case 2: Remover(); break;
                    case 3: Changer(); break;
                    case 4: OutPut(); break;
                    case 5: ForEach(); Pause(); break;
                    default: Console.Clear(); break;
                }
            }
        }
        //public static object Parse(Type t, string s) => TypeDescriptor.GetConverter(t).ConvertFromInvariantString(s);

        //public static T Parse(string s) => (T)Parse(typeof(T), s);
        
        private T GetValue(string value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
        private void Adder()
        {
            Console.Write($"Element kiriting: ");
            string a = Console.ReadLine();
            T t = GetValue(a);
            list.Add(t);
            Pause();
        }
        private void Remover()
        {
            Console.Write("Sizdagi elementlar: ");
            ForEach();
            Console.Write("\nBirini tanlang: ");
            string a = Console.ReadLine();
            T t = GetValue(a);
            if (list.Contains(t))
            {
                if (list.Remove(t)) Console.WriteLine("Successfully");
                else Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Ko'rib turib no to'g'ri kiritdingiz!");
            }
            Pause();
        }
        private void Changer()
        {
            Console.Write("Sizdagi elementlar: ");
            ForEach();
            Console.Write("\nBirini tanlang: ");
            string a = Console.ReadLine();
            T t = GetValue(a);
            if (list.Contains(t))
            {
                int i = list.IndexOf(t);
                if (i >= 0)
                {
                    Console.Write("Yangi element kiriting: ");
                    a = Console.ReadLine();
                    t = GetValue(a);
                    list[i] = t;
                }
                else Console.WriteLine("Error occured, please try again! ");
            }
            else
            {
                Console.WriteLine("Ko'rib turib no to'g'ri kiritdingiz!");
            }
            Pause();
        }
        private void OutPut()
        {
            Console.Write("Index kiriting: ");
            int i = int.Parse(Console.ReadLine());
            if (list.Count > i)
                Console.WriteLine(list[i]);
            else Console.WriteLine("Invalid index kiritdingiz!");

            Pause();
        }
        private void ForEach()
        {
            foreach (T item in list)
            {
                Console.Write(item + ", ");
            }
            //list.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
        }
        private void Pause() { Console.WriteLine($"Press any key to continue..."); Console.ReadKey(); }
    }
}
