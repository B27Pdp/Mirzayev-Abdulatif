using _3_modul.Lesson4_Regex.Homework.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex.Homework.Josus
{
    public class Boss
    {
        public EventHandler<Order> OnClick = delegate { };

        public void Mission()
        {
            Console.Write("Order: ");
            string? str = Console.ReadLine();

            Console.Write("Discription for order: ");
            string? discription = Console.ReadLine();

            var order = new Order
            {
                OrderOfBoss = str,
                DescriptionOfOrder = discription,
                DateTime = DateTime.Now,
            };

            OnClick.Invoke(this,order);
        }
        public void IsFinished(object? obj, Amount amount)
        {
            Console.WriteLine($"Amount: {amount.AmountOfOrder}$\nOrder is Finished: {amount.IsFinished}");
        }
    }
}
