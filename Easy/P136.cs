using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    // https://leetcode.com/problems/single-number
    public class P136
    {
        public static int SingleNumber(int[] nums)
        {
            return nums.Aggregate((acc, x) => acc ^ x);
        }
    }
}
