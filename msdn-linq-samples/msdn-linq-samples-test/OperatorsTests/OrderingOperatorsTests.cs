using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class OrderingOperatorsTests
    {
        private OrderingOperators _orderingOperators;

        [TestInitialize]
        public void Initialize()
        {
            _orderingOperators = new OrderingOperators();
        }

        [TestMethod]
        public void When_Linq28_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple28();
            Assert.AreEqual(result.FirstOrDefault(), "apple");
        }

        [TestMethod]
        public void When_Linq28_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple28();
            Assert.AreNotEqual(result.FirstOrDefault(), "cherry");
        }

        [TestMethod]
        public void When_Linq29_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple29();
            Assert.AreEqual(result.FirstOrDefault(), "apple");
        }

        [TestMethod]
        public void When_Linq29_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple29();
            Assert.AreNotEqual(result.FirstOrDefault(), "blueberry");
        }

        [TestMethod]
        public void When_Linq30_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple30();
            Assert.AreEqual(result.FirstOrDefault().ProductName, "Alice Mutton");
        }

        [TestMethod]
        public void When_Linq30_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple30();
            Assert.AreNotEqual(result.FirstOrDefault().ProductName, "Thringer");
        }

        [TestMethod]
        public void When_Linq31_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple31();
            Assert.AreEqual(result.FirstOrDefault(), "AbAcUs");
        }

        [TestMethod]
        public void When_Linq31_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple31();
            Assert.AreNotEqual(result.FirstOrDefault(), "aPPLE");
        }

        [TestMethod]
        public void When_Linq32_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple32();
            Assert.AreEqual(result.FirstOrDefault(), 4.1);
        }

        [TestMethod]
        public void When_Linq32_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple32();
            Assert.AreNotEqual(result.FirstOrDefault(), 1.7);
        }

        [TestMethod]
        public void When_Linq33_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple33();
            Assert.AreEqual(result.FirstOrDefault().ProductName, "Chang");
        }

        [TestMethod]
        public void When_Linq33_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple33();
            Assert.AreNotEqual(result.FirstOrDefault().ProductName, "Perth Pasties");
        }

        [TestMethod]
        public void When_Linq34_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple34();
            Assert.AreEqual(result.FirstOrDefault(), "ClOvEr");
        }

        [TestMethod]
        public void When_Linq34_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple34();
            Assert.AreNotEqual(result.FirstOrDefault(), "aPPLE");
        }

        [TestMethod]
        public void When_Linq35_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple35();
            Assert.AreEqual(result.FirstOrDefault(), "one");
        }

        [TestMethod]
        public void When_Linq35_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple35();
            Assert.AreNotEqual(result.FirstOrDefault(), "zero");
        }

        [TestMethod]
        public void When_Linq36_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple36();
            Assert.AreEqual(result.FirstOrDefault(), "aPPLE");
        }

        [TestMethod]
        public void When_Linq36_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple36();
            Assert.AreNotEqual(result.FirstOrDefault(), "AbAcUs");
        }

        [TestMethod]
        public void When_Linq37_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple37();
            Assert.AreEqual(result.FirstOrDefault().ProductName, "Thringer");
        }

        [TestMethod]
        public void When_Linq37_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple37();
            Assert.AreNotEqual(result.FirstOrDefault().ProductName, "Perth Pasties");
        }

        [TestMethod]
        public void When_Linq38_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple38();
            Assert.AreEqual(result.FirstOrDefault(), "aPPLE");
        }

        [TestMethod]
        public void When_Linq38_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple38();
            Assert.AreNotEqual(result.FirstOrDefault(), "AbAcUs");
        }

        [TestMethod]
        public void When_Linq39_Called_Should_Assert_true()
        {
            var result = _orderingOperators.Simple39();
            Assert.AreEqual(result.FirstOrDefault(), "nine");
        }

        [TestMethod]
        public void When_Linq39_Called_Should_Assert_false()
        {
            var result = _orderingOperators.Simple39();
            Assert.AreNotEqual(result.FirstOrDefault(), "zero");
        }
    }
}
