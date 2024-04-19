using Easy;

namespace LeetCode.Tests;

public class P704_Test
{
    [Test]
    public void Test()
    {
        // Arrange
        int[] arr = { -1,0,3,5,9,12 };
        var target = 9;
        
        var result = P704.Search(arr, target);
        // Act

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void Test2()
    {
        // Arrange
        int[] arr = { -1,0,3,5,9,12 };
        var target = 2;
        
        var result = P704.Search(arr, target);
        // Act

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}