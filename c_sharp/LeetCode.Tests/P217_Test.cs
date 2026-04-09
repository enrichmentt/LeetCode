using Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class P217_Test
    {
        [Test]
        public void Test()
        {
            var result = P217.ContainsDuplicate(new int[] { 1, 2, 3, 4, 5});

            Assert.IsFalse(result);
        }

        [Test]
        public void Test2()
        {
            var result = P217.ContainsDuplicate(new int[] { 1, 2, 3, 4, 5, 1 });

            Assert.IsTrue(result);
        }

        [Test]
        public void Test3()
        {
            var result = P217.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });

            Assert.IsTrue(result);
        }

        [Test]
        public void Test4()
        {
            var result = P217.ContainsDuplicate(new int[] { 1, 2, 3, 4, 5, 1, 3 });

            Assert.IsTrue(result);
        }

        [Test]
        public void Test5()
        {
            var result = P217.ContainsDuplicate(new int[] { -5, 12, 144, -7, 0 , 2, 5 });

            Assert.IsFalse(result);
        }
    }
}
