using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 5, 3, 5, 7, 9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 2, 2, 2, 1, 0 };

            CollectionAssert.AreEqual(expected, output);

        }
    }
}
