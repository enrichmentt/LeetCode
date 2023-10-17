using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    // https://leetcode.com/problems/move-zeroes
    public class P283
    {
        public static void MoveZeroes(int[] nums)
        {
            for(int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    j++;
                }
            }
        }
    }
}
