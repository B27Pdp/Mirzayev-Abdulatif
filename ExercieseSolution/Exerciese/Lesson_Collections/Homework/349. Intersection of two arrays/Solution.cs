using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Collections.Leetcode._349._Intersection_of_two_arrays
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();

            foreach (int i in nums1)
            {
                foreach (int j in nums2)
                {
                    if (i == j)
                    {
                        list.Add(i);
                    }
                }
            }

            return list.Distinct().ToArray();
        }
    }
}
