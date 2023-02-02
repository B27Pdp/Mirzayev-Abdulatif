using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson1_Delegate.Homework
{
    public class Mathematics
    {
        delegate void MathematicsDelegate(int a, int b);

        public void Run()
        {
            MathematicsDelegate del = Sum;
            del += Substract;
            del += Divide;
            del += Multiply;
            del.Invoke(50, 5);
        }
        private void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        private void Substract(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        private void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        private void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
}
