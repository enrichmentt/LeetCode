using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Easy
{
    public class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            var result = new int[nums.Length];
            var left = 0;
            var right = nums.Length - 1;
            var index = right;

            while (left <= right)
            {
                if (nums[left] * nums[left] > nums[right] * nums[right])
                {
                    result[index] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    result[index] = nums[right] * nums[right];
                    right--;
                }

                index--;
            }

            return result;
        }
    }
}
