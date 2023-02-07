using _3_modul.Lesson4_Regex.Homework.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex.Homework.Josus
{
    public class Agent
    {
        List<Order> _agents = new();

        public EventHandler<Amount> AgentReceived = delegate { };
        delegate void Action();
        public void GetOrder(object? obj, Order order)
        {
            Console.WriteLine();
            Console.WriteLine("Order arrived");
            _agents.Add(order);
            Action del = IsFinished;
            del.Invoke();
        }

        public void IsFinished()
        {
            Amount at = new()
            {
                AmountOfOrder = new Random { }.Next(10000, 1000000),
                IsFinished = true
            };
            AgentReceived.Invoke(null, at);
        }

    }
}
