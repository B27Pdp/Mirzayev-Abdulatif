using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Collections.Leetcode
{
    public class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> _list1 = list1.ToList();
            List<string> _list2 = list2.ToList();

            int big = int.MaxValue, index;
            List<string> str = new();

            for (int i = 0; i < _list1.Count; i++)
            {
                if (_list2.Contains(_list1[i]))
                {
                    index = _list2.IndexOf(_list1[i]) + _list1.IndexOf(_list1[i]);

                    if (index < big)
                    {
                        str.Clear();
                        str.Add(_list1[i]);
                        big = index;
                    }
                    else if (index == big)
                    {
                        str.Add(_list1[i]);
                        big = index;
                    }
                }
            }
            return str.ToArray();
        }
    }
}
