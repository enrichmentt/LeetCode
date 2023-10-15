using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    public class P1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] != target) continue;
                    if (i == j)
                        continue;
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
            return result;
        }
    }
}
