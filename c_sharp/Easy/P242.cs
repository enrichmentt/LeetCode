namespace Easy;

public class P242
{
    // https://leetcode.com/problems/valid-anagram/
    public static bool IsAnagram(string s, string t) {
        char[] ss = s.ToCharArray();
        char[] tt = t.ToCharArray();
        
        Array.Sort(ss);
        Array.Sort(tt);
        
        return new string(ss) == new string(tt);
    }
    
    public static bool IsAnagramWithLinq(string s, string t)
    {
        s = string.Concat(s.OrderBy(x => x));
        t = string.Concat(t.OrderBy(x => x));

        return s == t;
    }
}