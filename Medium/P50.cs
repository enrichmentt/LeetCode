using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium
{
    // https://leetcode.com/problems/powx-n/
    public class P50
    {
        public static double MyPow(double x, int n)
        {
            if (n == 1)
                return x;
            if (n == 0)
                return 1;
            if (n == -1)
                return 1 / x;
            if (n == 2)
                return x * x;
            return MyPow(MyPow(x, n / 2), 2) * MyPow(x, n % 2);
        }
    }
}
