using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    public class P9
    {
        public static bool IsPalindrome(int x)
        {
            var intToString = x.ToString();
            int i = 0;

            do
            {
                if (intToString[i] != intToString[intToString.Length - i - 1])
                    return false;

                i++;

            } while (i < intToString.Length / 2 );
            
            return true;
        }
    }
}
