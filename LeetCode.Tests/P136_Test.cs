using Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class P136_Test
    {
        [Test]
        public void Test()
        {
            var result = P136.SingleNumber(new int[] { 2, 2, 1 });
            var expected = 1;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var result = P136.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
            var expected = 4;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var result = P136.SingleNumber(new int[] { 1 });
            var expected = 1;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var result = P136.SingleNumber(new int[] { 1,5,3,5,3,6, 1 });
            var expected = 6;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
