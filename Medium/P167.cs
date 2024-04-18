namespace Medium;

public static class P167
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        HashSet<int> hashSet = new HashSet<int>();
        
        for(var i = 0; i < numbers.Length; i++)
        {
            var secondNum = target - numbers[i];
            if (hashSet.Contains(numbers[i]))
            {
                var indexSecondNum = Array.IndexOf(numbers, secondNum);
                var result = new[] { indexSecondNum + 1, i + 1 };
                return result;
            }

            hashSet.Add(secondNum);
        }

        return Array.Empty<int>();
    }
}