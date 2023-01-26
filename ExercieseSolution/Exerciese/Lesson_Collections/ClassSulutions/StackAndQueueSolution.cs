using Exerciese.Collections.ClassSulutions.classes;

namespace Exerciese.Collections.ClassSulutions
{
    public class StackAndQueueSolutions
    {
        public static void StackRun(Page p)
        {
            Stack<Page> pages = new();
            Page l = new Page() { Id = 2, Name = "Hello" };
            pages.Push(p);
            pages.Push(l);
            pages.Push(new Page() { Id = 3, Name = "Salom" });

            Console.WriteLine(pages.First().Name);

            Console.WriteLine(pages.Peek().Name);

            Console.WriteLine(pages.EnsureCapacity(7));
            Console.WriteLine(pages);
            pages.Push(new Page() { Id = 4, Name = "OOP" });
            pages.Clear();

            Console.WriteLine(pages.TryPop(out p));

            Console.WriteLine();

        }
        public void QueueRun()
        {
            Queue<User> users = new();

        }
    }
}

