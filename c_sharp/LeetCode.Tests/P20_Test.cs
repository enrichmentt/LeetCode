using Easy;

namespace LeetCode.Tests;

public class P20_Test
{
    [Test]
    public void Test()
    {
        // Arrange
        var str = "()";
        // Act
        var result = P20.IsValid(str);
        // Assert
        Assert.True(result);
    }
    
    [Test]
    public void Test2()
    {
        // Arrange
        var str = "()[]{}";
        // Act
        var result = P20.IsValid(str);
        // Assert
        Assert.True(result);
    }
    
    [Test]
    public void Test3()
    {
        // Arrange
        var str = "(]";
        // Act
        var result = P20.IsValid(str);
        // Assert
        Assert.False(result);
    }
    
    [Test]
    public void Test4()
    {
        // Arrange
        var str = "]";
        // Act
        var result = P20.IsValid(str);
        // Assert
        Assert.False(result);
    }
}