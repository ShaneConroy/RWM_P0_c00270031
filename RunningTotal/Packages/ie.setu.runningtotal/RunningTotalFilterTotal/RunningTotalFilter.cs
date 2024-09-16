using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class RunningTotalTest
    {
        [Test]
        public void RunningTotalSimple()
        {
            int[] input = { 5, 3, 1, 100, 1, 15};
            int[] output = RunningTotal.running_total(input);
            int[] expected = { 5, 8, 9, 109, 110, 125 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
