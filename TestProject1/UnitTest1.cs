using CaseStudy1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var r = new int[] { 7, 1, 5, 3, 6, 4 };
            var result =Case1.GetProfit(r);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test2()
        {
            var r = new int[] { 37, 26, 14, 8, 1 };
            var result = Case1.GetProfit(r);
            Assert.AreEqual(0, result);
        }
    }
}