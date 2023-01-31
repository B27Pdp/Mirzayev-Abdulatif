using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Leeson_Enumerable.Classwork
{
    public class Person : IPerson//, IEnumerable
    {
        public string Name { get; set; }

        public int Id { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    yield return this;
        //}

        public void Speak()
        {
            Console.WriteLine("Hello...");
        }

    }
}
