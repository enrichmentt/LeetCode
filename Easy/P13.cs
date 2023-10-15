using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    // https://leetcode.com/problems/roman-to-integer/
    public class P13
    {
        private static readonly Dictionary<char, int> romanNumbers = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int RomanToInt(string s)
        {
            var result = 0;
            var newValue = 0;
            var oldValue = 0;

            foreach (var c in s)
            {
                newValue = romanNumbers[c];

                if (newValue > oldValue)
                    result = result + newValue - 2 * oldValue;
                else
                    result = result + newValue;

                oldValue = newValue;
            }

            return result;
        }
    }
}
