using System.Text;
using System.Text.RegularExpressions;

namespace Easy;

public static class P125
{
    public static bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
                sb.Append(s[i]);
        }
        s = sb.ToString().ToLower();
        
        var leftIndex = 0;
        var rightIndex = s.Length - 1;
        
        for (var i = 0; i < s.Length  / 2; i++)
        {
            if (s[leftIndex] != s[rightIndex])
                return false;
            leftIndex++;
            rightIndex--;
        }
        
        return true;
    }
}