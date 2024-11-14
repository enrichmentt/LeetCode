namespace Easy;

public static class P69
{
    public static int MySqrt(int x)
    {
        if (x == 0)
            return 0;
        
        var t = 1.0;
        var result = x / 2.0;
        do
        {
            t = result;
            result = (t + (x / t)) / 2;
        } while ((t - result) != 0);
        return (int)result;
    }
}