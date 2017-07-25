using System;
using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class JoinOperatorsTests
    {
        private JoinOperators _joinOperators;

        [TestInitialize]
        public void Initialize()
        {
            _joinOperators = new JoinOperators();
        }

        [TestMethod]
        public void When_Linq102_Called_Should_Assert_true()
        {
            var result = _joinOperators.Simple102();
            Assert.AreEqual(result.First().ProductName, "Chef Anton's Gumbo Mix");
        }

        [TestMethod]
        public void When_Linq102_Called_Should_Assert_false()
        {
            var result = _joinOperators.Simple102();
            Assert.AreNotEqual(result.First().ProductName, "Perth Pasties");
        }

        [TestMethod]
        public void When_Linq103_Called_Should_Assert_true()
        {
            var result = _joinOperators.Simple103();
            Assert.AreEqual(result.First().Products.First().ProductName, "Chef Anton's Gumbo Mix");
        }

        [TestMethod]
        public void When_Linq103_Called_Should_Assert_false()
        {
            var result = _joinOperators.Simple103();
            Assert.AreNotEqual(result.First().Products.First().ProductName, "Perth Pasties");
        }

        [TestMethod]
        public void When_Linq104_Called_Should_Assert_true()
        {
            var result = _joinOperators.Simple102();
            Assert.AreEqual(result.First().ProductName, "Chef Anton's Gumbo Mix");
        }

        [TestMethod]
        public void When_Linq104_Called_Should_Assert_false()
        {
            var result = _joinOperators.Simple102();
            Assert.AreNotEqual(result.First().ProductName, "Alice Mutton");
        }

        [TestMethod]
        public void When_Linq105_Called_Should_Assert_true()
        {
            var result = _joinOperators.Simple102();
            Assert.AreEqual(result.First().ProductName, "Chef Anton's Gumbo Mix");
        }

        [TestMethod]
        public void When_Linq105_Called_Should_Assert_false()
        {
            var result = _joinOperators.Simple102();
            Assert.AreNotEqual(result.First().ProductName, "Alice Mutton");
        }
    }
}
