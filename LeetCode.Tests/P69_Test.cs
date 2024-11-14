using Easy;

namespace LeetCode.Tests;

public class P69_Test
{
    [Test]
    public void Test1()
    {
        var result = P69.MySqrt(9);
        var expected = 3;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        var result = P69.MySqrt(121);
        var expected = 11;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        var result = P69.MySqrt(8);
        var expected = 2;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        var result = P69.MySqrt(0);
        var expected = 0;
        Assert.That(result, Is.EqualTo(expected));
    }
}