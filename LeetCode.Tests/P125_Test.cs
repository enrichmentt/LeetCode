using Easy;

namespace LeetCode.Tests;

public class P125_Test
{
    [Test]
    public void Test1()
    {
        // Arrange
        var s = "A man, a plan, a canal: Panama";
        var result = P125.IsPalindrome(s);
        // Act

        // Assert
        Assert.IsTrue(result);
    }
    
    [Test]
    public void Test2()
    {
        // Arrange
        var s = "race a car";
        var result = P125.IsPalindrome(s);
        // Act

        // Assert
        Assert.IsFalse(result);
    }
    
    [Test]
    public void Test3()
    {
        // Arrange
        var s = " ";
        var result = P125.IsPalindrome(s);
        // Act

        // Assert
        Assert.IsTrue(result);
    }
}