using Easy;

namespace LeetCode.Tests;

public class P70_Test
{
    [Test]
    public void Test()
    {
        var result = P70.ClimbStairs(3);
        
        var expected = 3;

        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test1()
    {
        var result = P70.ClimbStairs(2);
        
        var expected = 2;

        Assert.That(result, Is.EqualTo(expected));
    }
}