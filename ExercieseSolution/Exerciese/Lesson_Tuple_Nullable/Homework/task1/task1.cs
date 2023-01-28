using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task1
{
    public static class task1
    {
        public static void Run()
        {
            Person husband = new()
            {
                Id = 1,
                Age = 20,
                Name = "Man",
            };

            Person wife = new()
            { 
                Age = 25,
                Id = 2,
                Name = "Woman"
            };

            Person husband1 = new()
            {
                Id = 4,
                Age = 20,
                Name = "Man1",
            };

            Person wife1 = new()
            {
                Age = 25,
                Id = 3,
                Name = "Woman1"
            };


            TripleDictionary<int, Person, Person> test = new();


            test.Add(4, husband, wife);
            test.Add(7, husband1, wife1);
            test.Add(3, new Person() { Age = 44, Id = 5, Name = "Ju"}, new Person() { Age = 33, Id = 8, Name = "Hu" });

            var t = test.OrderBy();

            test.GetByIndex(0);

            

        }
    }
}
