using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task1
{
    public static class task1
    {
        public static void Run()
        {
            Person person = new()
            {
                Id = 1,
                Age = 20,
                Name = "Val",
            };

            object[] arr = new object[10];

            Random rand = new();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(10, 45);
            }

            TripleDictionary<object, Person, Person> test = new();

            test.TProp = arr;

            object[] obj = test.OrderBy();
            
            foreach (object obj2 in obj)
            {
                Console.Write(obj2 + " ");
            }

            obj = test.OrderByDesc();
            Console.WriteLine();

            foreach (object obj2 in obj)
            {
                Console.Write(obj2 + " ");
            }


        }
    }
}
