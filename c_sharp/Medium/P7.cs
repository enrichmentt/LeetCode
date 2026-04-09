namespace Medium;

public class P7
{
    public static int Reverse(int x)
    {
        var reverse = 0;
        var isNegative = false;
        if (x < 0)
        {
            isNegative = true;
            x = x * -1;
        }

        while (x > 0)
        {
            if(reverse > int.MaxValue / 10 || reverse < int.MinValue / 10) return 0;
            
            reverse = reverse * 10 + x % 10;
            x = x / 10;
        }
        
        if (isNegative)
            return reverse * -1;
        return reverse;
    }
}