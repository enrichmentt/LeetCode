using Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    internal class P1_Test
    {
        [Test]
        public void TwoSum1()
        {
            int[] arr = { 2, 7, 11, 15 };
            var target = 9;
            var result = P1.TwoSum(arr, target);
            var output = new int[] { 0, 1 };

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void TwoSum2()
        {
            int[] arr = { 3, 2, 4 };
            var target = 7;
            var result = P1.TwoSum(arr, target);

            var output = new int[] { 0, 2 };

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void TwoSum3()
        {
            int[] arr = { -2, 2, 4, 1, 3 };
            var target = 0;
            var result = P1.TwoSum(arr, target);

            var output = new int[] { 0, 1 };

            Assert.That(output, Is.EqualTo(result));
        }

        [Test]
        public void TwoSum4()
        {
            int[] arr = { -2, -1, 4, 1, 3 };
            var target = -3;
            var result = P1.TwoSum(arr, target);

            var output = new int[] { 0, 1 };

            Assert.That(output, Is.EqualTo(result));
        }
    }
}
