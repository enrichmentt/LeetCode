using Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class P283_Test
    {
        [Test]
        public void Test()
        {
            var numbers = new int[] { 0, 1, 0, 3, 12 };

            P283.MoveZeroes(numbers);

            var expected = new int[] { 1, 3, 12, 0, 0 };

            Assert.That(numbers, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var numbers = new int[] { 0 };

            P283.MoveZeroes(numbers);

            var expected = new int[] { 0 };

            Assert.That(numbers, Is.EqualTo(expected));
        }
    }
}
