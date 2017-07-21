using System;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class ElementOperatorsTests
    {
        private ElementOperators _elementOperators;

        [TestInitialize]
        public void Initialize()
        {
            _elementOperators = new ElementOperators();
        }

        [TestMethod]
        public void When_Linq58_Called_Should_Assert_true()
        {
            var result = _elementOperators.Simple58();
            Assert.AreEqual(result.ProductName, "Chef Anton's Gumbo Mix");
        }

        [TestMethod]
        public void When_Linq58_Called_Should_Assert_false()
        {
            var result = _elementOperators.Simple58();
            Assert.AreNotEqual(result.ProductId, 1);
        }

        [TestMethod]
        public void When_Linq59_Called_Should_Assert_true()
        {
            var result = _elementOperators.Simple59();
            Assert.AreEqual(result, "one");
        }

        [TestMethod]
        public void When_Linq59_Called_Should_Assert_false()
        {
            var result = _elementOperators.Simple59();
            Assert.AreNotEqual(result, "zero");
        }

        [TestMethod]
        public void When_Linq61_Called_Should_Assert_true()
        {
            var result = _elementOperators.Simple61();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void When_Linq61_Called_Should_Assert_false()
        {
            var result = _elementOperators.Simple61();
            Assert.AreNotEqual(result, null);
        }

        [TestMethod]
        public void When_Linq62_Called_Should_Assert_true()
        {
            var result = _elementOperators.Simple62();
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"Should return null")]
        public void When_Linq62_Called_Should_Assert_false()
        {
            var result = _elementOperators.Simple62();
            Assert.AreNotEqual(result.ProductId, 1);
        }

        [TestMethod]
        public void When_Linq64_Called_Should_Assert_true()
        {
            var result = _elementOperators.Simple64();
            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void When_Linq64_Called_Should_Assert_false()
        {
            var result = _elementOperators.Simple64();
            Assert.AreNotEqual(result, 4);
        }
    }
}
