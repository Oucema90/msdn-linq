using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class PartitioningOperatorsTests
    {
        private PartitioningOperators _partitioningOperators;

        [TestInitialize]
        public void Initialize()
        {
            _partitioningOperators = new PartitioningOperators();
        }

        [TestMethod]
        public void When_Linq20_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple20();
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void When_Linq20_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple20();
            Assert.AreNotEqual(4, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq21_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple21();
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void When_Linq21_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple21();
            var firstOrDefault = result.FirstOrDefault();
            if (firstOrDefault != null) Assert.AreNotEqual(2, firstOrDefault.CustomerId);
        }

        [TestMethod]
        public void When_Linq22_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple22();
            Assert.AreEqual(6, result.Count());
        }

        [TestMethod]
        public void When_Linq22_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple22();
            Assert.AreNotEqual(2, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq23_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple23();
            Assert.AreEqual(6, result.Count());
        }

        [TestMethod]
        public void When_Linq23_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple23();
            var firstOrDefault = result.FirstOrDefault();
            if (firstOrDefault != null) Assert.AreNotEqual(1, firstOrDefault.CustomerId);
        }

        [TestMethod]
        public void When_Linq24_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple24();
            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        public void When_Linq24_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple24();
            Assert.AreNotEqual(4, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq25_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple25();
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void When_Linq25_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple25();
            Assert.AreNotEqual(4, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq26_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple26();
            Assert.AreEqual(7, result.Count());
        }

        [TestMethod]
        public void When_Linq26_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple26();
            Assert.AreNotEqual(5, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq27_Called_Should_Assert_true()
        {
            var result = _partitioningOperators.Simple27();
            Assert.AreEqual(8, result.Count());
        }

        [TestMethod]
        public void When_Linq27_Called_Should_Assert_false()
        {
            var result = _partitioningOperators.Simple27();
            Assert.AreNotEqual(5, result.FirstOrDefault());
        }
    }
}