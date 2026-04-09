using Medium;

namespace LeetCode.Tests;

public class P7_Test
{
    [Test]
    public void Reverse1()
    {
        var result = P7.Reverse(123);
        Assert.AreEqual(321, result);
    }
    
    [Test]
    public void Reverse2()
    {
        var result = P7.Reverse(3210);
        Assert.That(result, Is.EqualTo(123));
    }
    
    [Test]
    public void Reverse3()
    {
        var result = P7.Reverse(-123);
        Assert.That(result, Is.EqualTo(-321));
    }
    
    [Test]
    public void Reverse4()
    {
        var result = P7.Reverse(1534236469);
        Assert.That(result, Is.EqualTo(0));
    }
}