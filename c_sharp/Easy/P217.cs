using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    // https://leetcode.com/problems/contains-duplicate/
    public class P217
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) return true;
            }

            return false;
        }
    }
}
