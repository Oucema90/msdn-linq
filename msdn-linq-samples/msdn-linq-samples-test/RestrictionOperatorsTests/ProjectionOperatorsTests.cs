using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.RestrictionOperatorsTests
{
    [TestClass]
    public class ProjectionOperatorsTests
    {
        private ProjectionsOperators _projectionsOperators;

        [TestInitialize]
        public void Initialize()
        {
            _projectionsOperators = new ProjectionsOperators();
        }

        [TestMethod]
        public void When_Linq6_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple6();
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void When_Linq6_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple6();
            Assert.AreNotEqual(5, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq7_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple7();
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void When_Linq7_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple7();
            Assert.AreNotEqual("The word Chef Anton's Gumbo Mix is greater than its value.", result.LastOrDefault());
        }

        [TestMethod]
        public void When_Linq8_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple8();
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void When_Linq8_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple8();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("The word five is greater than its value.", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq9_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple9();
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void When_Linq9_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple9();
            var last = result.Last();
            Assert.AreNotEqual("cHeRrY", last.Lower);
        }

        [TestMethod]
        public void When_Linq10_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple10();
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void When_Linq10_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple10();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("The digit five is even.", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq11_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple11();
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void When_Linq11_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple11();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("Chef Anton's Gumbo Mix is on sold!", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq12_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple12();
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void When_Linq12_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple12();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("5: True", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq13_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple13();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void When_Linq13_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple13();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("zero", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq14_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple14();
            Assert.AreEqual(16, result.Count());
        }

        [TestMethod]
        public void When_Linq14_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple14();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("0 is great than 1", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq15_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple15();
            Assert.AreEqual(6, result.Count());
        }

        [TestMethod]
        public void When_Linq15_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple15();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("CustomerID=2 OrderId=10482 Total=152,0", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq16_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple16();
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void When_Linq16_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple16();
            var firstOrDefault = result.FirstOrDefault();

            Assert.AreNotEqual("CustomerID=7 OrderId=10269 OrderDate=1.08.1998 13:00:00", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq17_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple17();
            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        public void When_Linq17_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple17();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("CustomerID=1 OrderId=10572 Total=254,0", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq18_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple18();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void When_Linq18_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple18();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("CustomerID=2 OrderId=10482", firstOrDefault);
        }

        [TestMethod]
        public void When_Linq19_Called_Should_Assert_true()
        {
            var result = _projectionsOperators.Simple19();
            Assert.AreEqual(8, result.Count());
        }

        [TestMethod]
        public void When_Linq19_Called_Should_Assert_false()
        {
            var result = _projectionsOperators.Simple19();
            var firstOrDefault = result.FirstOrDefault();
            Assert.AreNotEqual("The word Customer #1 has an order with OrderID 10482 is greater than its value.", firstOrDefault);
        }
    }
}
