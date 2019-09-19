using NUnit.Framework;
using WaveFilterer.Library;
using System.Collections.Generic;

namespace Tests
{
    public class WaveFiltererTests
    {

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void WaveFilter_Returns5_WhenPassed5()
        {
            int[] input = { 5 };

            var output = WaveFilters.FilterWaves(input);
            var expectedOutput = new int[] { 5 };

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void WaveFilter_Returns10_WhenPassed10()
        {
            int[] input = { 10 };

            var output = WaveFilters.FilterWaves(input);
            var expectedOutput = new int[] { 10 };

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void WaveFilter_Returns5_WhenPassed3()
        {
            int[] input = { 3 };

            var output = WaveFilters.FilterWaves(input);
            var expectedOutput = new int[] { 5 };

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void WaveFilter_Returns20_WhenPassed25()
        {
            int[] input = { 25 };

            var output = WaveFilters.FilterWaves(input);
            var expectedOutput = new int[] { 20 };

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void WaveFilter_Returns5And10_WhenPassed3And10()
        {
            var input = new int[] { 3, 10 };

            var output = WaveFilters.FilterWaves(input);
            var expectedOutput = new int[] { 5, 10};

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void WaveFilter_Returns20And10And5_WhenPassed35And10And2()
        {
            var input = new int[] { 35, 10, 2 };

            var output = WaveFilters.FilterWaves(input);
            var expectedOutput = new int[] { 20, 10, 5 };

            Assert.AreEqual(expectedOutput, output);
        }
    }
}