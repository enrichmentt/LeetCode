using Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class P50_Test
    {
        [Test]
        public void Test()
        {
            var result = P50.MyPow(2.0, 2);

            var expected = 4.0;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var result = P50.MyPow(2.0, -2);

            var expected = 0.25;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var result = P50.MyPow(10.0, 0);

            var expected = 1.0;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var result = P50.MyPow(-10, 2);

            var expected = 100.0;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test5()
        {
            var result = P50.MyPow(1, -2147483648);

            var expected = 1.0;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test6()
        {
            var result = P50.MyPow(0.00001, 2147483647);

            var expected = 0.0;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
