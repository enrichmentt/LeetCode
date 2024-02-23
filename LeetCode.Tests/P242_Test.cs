using Easy;

namespace LeetCode.Tests;

public class P242_Test
{
    [Test]
    public void IsAnagram()
    {
        string s = "anagram";
        string t = "nagaram";
        var result = P242.IsAnagram(s, t);
        Assert.IsTrue(result);
    }

    [Test]
    public void IsAnagram_2()
    {
        string s = "rat";
        string t = "cat";
        var result = P242.IsAnagram(s, t);
        Assert.IsFalse(result);
    }
    
    [Test]
    public void IsAnagramWithLinq()
    {
        string s = "anagram";
        string t = "nagaram";
        var result = P242.IsAnagramWithLinq(s, t);
        Assert.IsTrue(result);
    }
    
    [Test]
    public void IsAnagramWithLinq_2()
    {
        string s = "rat";
        string t = "cat";
        var result = P242.IsAnagramWithLinq(s, t);
        Assert.IsFalse(result);
    }
}