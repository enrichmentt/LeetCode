using Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class P9_Test
    {
        [Test]
        public void Test()
        {
            var result = P9.IsPalindrome(10);
            var expected = false;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var result = P9.IsPalindrome(121);
            var expected = true;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var result = P9.IsPalindrome(-121);
            var expected = false;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var result = P9.IsPalindrome(1221);
            var expected = true;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test5()
        {
            var result = P9.IsPalindrome(1000021);
            var expected = false;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
