using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Easy;

namespace Easy
{
    public class SquaresOfASortedArray_Test
    {
        [Test]
        [TestCaseSource(nameof(Data))]
        public void Test1(int[] input, int[] want)
        {
            var got = SquaresOfASortedArray.SortedSquares(input);

            Assert.That(got, Is.EqualTo(want));
        }

        public static IEnumerable<object[]> Data =>
        [
            [new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 }],
            [new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 }]
        ];
    }
}
