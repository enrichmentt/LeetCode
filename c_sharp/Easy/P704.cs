namespace Easy;

// https://leetcode.com/problems/binary-search
public static class P704
{
    public static int Search(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end) 
        {
            var middlePoint = (start + end) / 2;
            if (nums[middlePoint] < target)
            {
                start = middlePoint + 1;
            }
            else if (nums[middlePoint] > target)
            {
                end = middlePoint - 1;
            }
            else return middlePoint;
        }

        return -1;
    }
}