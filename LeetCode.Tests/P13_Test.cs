using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy;

namespace LeetCode.Tests
{
    public class P13_Test
    {
        [Test]
        public void Test1()
        {
            var input = "III";
            int output = 3;

            var result = P13.RomanToInt(input);

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void Test2()
        {
            var input = "LVIII";
            int output = 58;

            var result = P13.RomanToInt(input);

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void Test3()
        {
            var input = "MCMXCIV";
            int output = 1994;

            var result = P13.RomanToInt(input);

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void Test4()
        {
            var input = "MMXXIII";
            int output = 2023;

            var result = P13.RomanToInt(input);

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void Test5()
        {
            var input = "MMMMMDCCCLXIII";
            int output = 5863;

            var result = P13.RomanToInt(input);

            Assert.That(output, Is.EqualTo(result));
        }
    }
}
