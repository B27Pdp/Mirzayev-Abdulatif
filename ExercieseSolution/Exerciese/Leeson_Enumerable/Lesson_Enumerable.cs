using Exerciese.Leeson_Enumerable.Homework;
using Exerciese.Lesson_Indexer.Homework;

namespace Exerciese.Leeson_Enumerable
{
    public class Lesson_Enumerable
    {
        public static void Run()                                                                                               
        {
            /*
            MyGenericList<string> list = new MyGenericList<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");
            list.Add("six");
            list.Add("seven");
            list.Add("eight");
            list.Add("nine");
            list.Add("ten");

            list.Add("Xolmat");
            list[0] = "Abdulatif";
            list[1] = "Mirzayev";

            //list.ForEach(x => Console.WriteLine(x));

            string[] strings = list.ToArray();

            list.Remove("Abdulatif");
            list.Remove("Mirzayev");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            */
            /*
            Random ran = new Random();
            MyGenericList<int> nums = new MyGenericList<int>();

            for (int i = 0; i < 50; i++)
            {
                nums.Add(ran.Next(1, 100));
            }

            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }
            */

            Dictionary.Run();

        }
        
    }
}
