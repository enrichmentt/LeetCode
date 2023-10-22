namespace Easy;

// https://leetcode.com/problems/climbing-stairs/
public class P70
{
    public static int ClimbStairs(int n)
    {
        int[] arr = new int[n + 1]; 
        arr[0] = 1; 
        arr[1] = 1; 
  
        for (int i = 2; i <= n; i++) 
            arr[i] = arr[i - 1] + arr[i - 2]; 
        return arr[n]; 
    }
}