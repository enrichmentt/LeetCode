using Medium;

namespace LeetCode.Tests;

public class MinStack_Test
{
    [Test]
    public void Test()
    {
        var minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        var min = minStack.GetMin();
        minStack.Pop();
        var top = minStack.Top();
        var min2 = minStack.GetMin();

        
        Assert.That(min, Is.EqualTo(-3));
        Assert.That(top, Is.EqualTo(0));
        Assert.That(min2, Is.EqualTo(-2));
    }
    
    [Test]
    public void Test2()
    {
        var minStack = new MinStack();
        minStack.Push(2);
        minStack.Push(0);
        minStack.Push(3);
        minStack.Push(0);
        var min = minStack.GetMin();
        minStack.Pop();
        var min2 = minStack.GetMin();
        minStack.Pop();
        var min3 = minStack.GetMin();
        minStack.Pop();
        var min4 = minStack.GetMin();
        
        
        Assert.That(min, Is.EqualTo(0));
        Assert.That(min2, Is.EqualTo(0));
        Assert.That(min3, Is.EqualTo(0));
        Assert.That(min4, Is.EqualTo(2));
    }
}