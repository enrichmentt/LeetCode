using Medium;

namespace LeetCode.Tests;

public class P167_Test
{
    [Test]
    public void Test()
    {
        int[] arr = { 2, 7, 11, 15 };
        var target = 9;
        
        var result = P167.TwoSum(arr, target);
        
        Assert.That(new int[] { 1, 2 }, Is.EqualTo(result));
    }

    [Test]
    public void Test1()
    {
        int[] arr = { 2, 3, 4 };
        var target = 6;
        
        var result = P167.TwoSum(arr, target);

        Assert.That(new int[]{1,3}, Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] arr = { -1, 0 };
        var target = -1;
        
        var result = P167.TwoSum(arr, target);

        Assert.That(new int[]{1,2}, Is.EqualTo(result));
    }
}