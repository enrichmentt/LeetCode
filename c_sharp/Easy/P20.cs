namespace Easy;

public static class P20
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;
        
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };

        foreach (var ch in s)
        {
            if(dict.ContainsKey(ch))
                stack.Push(ch);
            else if (stack.Count > 0 && dict[stack.Peek()] == ch)
                stack.Pop();
            else return false;
        }
        
        return stack.Count == 0;
    }
}