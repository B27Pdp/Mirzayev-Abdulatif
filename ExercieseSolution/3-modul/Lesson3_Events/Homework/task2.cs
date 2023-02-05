using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events.Homework
{
    public class task2
    {

        public EventHandler<EventArgs> OnEvenNumberFound = delegate { };

		private List<int>? _list;

		public List<int> ListOfElement
		{
			set
			{
				int a = value.Find(a => a % 2 == 0);
				if(a > 0)
				{
					OnEvenNumberFound.Invoke(this, new EventArgs());
				}
			}
		}




	}
}
