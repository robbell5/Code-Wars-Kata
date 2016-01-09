using Code_Wars_Kata.FilterCoffee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Code_Wars_Kata_Tests.FilterCoffeeTest
{
    [TestFixture]
    public class FilerCoffeeTests
    {
        [Test]
        [TestCase(3, new int[] { 6, 1, 2, 9, 2 }, new int[] { 1, 2, 2 })]
        [TestCase(14, new int[] { 7, 3, 23, 9, 14, 20, 7 }, new int[] { 3, 7, 7, 9, 14 })]
        [TestCase(0, new int[] { 6, 1, 2, 9, 2 }, new int[] { })]
        public void FixedTest(int budget, int[] prices, int[] expectedResults)
        {
            int[] results = FilterCoffee.Search(budget, prices);
            Assert.AreEqual(expectedResults, results);
        }
    }
}
