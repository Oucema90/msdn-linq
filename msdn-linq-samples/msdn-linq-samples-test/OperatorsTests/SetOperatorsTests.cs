using System;
using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class SetOperatorsTests
    {
        private SetsOperators _setOperators;

        [TestInitialize]
        public void Initialize()
        {
            _setOperators = new SetsOperators();
        }

        [TestMethod]
        public void When_Linq46_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple46();
            Assert.AreEqual(result.FirstOrDefault(), 2);
        }

        [TestMethod]
        public void When_Linq46_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple46();
            Assert.AreNotEqual(result.Count(), 4);
        }

        [TestMethod]
        public void When_Linq47_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple47();
            Assert.AreEqual(result.Count(), 5);
        }

        [TestMethod]
        public void When_Linq47_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple47();
            Assert.AreNotEqual(result.FirstOrDefault(), "Meublatex");
        }

        [TestMethod]
        public void When_Linq48_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple48();
            Assert.AreEqual(result.FirstOrDefault(), 0);
        }

        [TestMethod]
        public void When_Linq48_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple48();
            Assert.AreNotEqual(result.FirstOrDefault(), 15);
        }

        [TestMethod]
        public void When_Linq49_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple49();
            Assert.AreEqual(result.FirstOrDefault(), 'C');
        }

        [TestMethod]
        public void When_Linq49_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple49();
            Assert.AreNotEqual(result.FirstOrDefault(), 'A');
        }

        [TestMethod]
        public void When_Linq50_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple50();
            Assert.AreEqual(result.Count(), 2);
        }

        [TestMethod]
        public void When_Linq50_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple50();
            Assert.AreNotEqual(result.FirstOrDefault(), 0);
        }

        [TestMethod]
        public void When_Linq51_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple51();
            Assert.AreEqual(result.FirstOrDefault(), 'T');
        }

        [TestMethod]
        public void When_Linq51_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple51();
            Assert.AreNotEqual(result.FirstOrDefault(), 'A');
        }

        [TestMethod]
        public void When_Linq52_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple52();
            Assert.AreEqual(result.Count(), 5);
        }

        [TestMethod]
        public void When_Linq52_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple52();
            Assert.AreNotEqual(result.FirstOrDefault(), 1);
        }

        [TestMethod]
        public void When_Linq53_Called_Should_Assert_true()
        {
            var result = _setOperators.Simple53();
            Assert.AreEqual(result.FirstOrDefault(), 'C');
        }

        [TestMethod]
        public void When_Linq53_Called_Should_Assert_false()
        {
            var result = _setOperators.Simple53();
            Assert.AreNotEqual(result.FirstOrDefault(), 'A');
        }
    }
}
