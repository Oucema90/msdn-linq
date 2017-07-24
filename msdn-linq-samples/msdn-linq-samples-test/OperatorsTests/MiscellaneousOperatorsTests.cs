using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class MiscellaneousOperatorsTests
    {
        private MiscellaneousOperators _miscellaneousOperators;

        [TestInitialize]
        public void Initialize()
        {
            _miscellaneousOperators = new MiscellaneousOperators();
        }

        [TestMethod]
        public void When_Linq94_Called_Should_Assert_true()
        {
            var result = _miscellaneousOperators.Simple94();
            Assert.AreEqual(result.First(), 0);
            Assert.AreEqual(result.Count(), 12);
        }

        [TestMethod]
        public void When_Linq94_Called_Should_Assert_false()
        {
            var result = _miscellaneousOperators.Simple94();
            Assert.AreNotEqual(result.First(), 1);
            Assert.AreNotEqual(result.Count(), 7);
        }

        [TestMethod]
        public void When_Linq95_Called_Should_Assert_true()
        {
            var result = _miscellaneousOperators.Simple95();
            Assert.AreEqual(result.First(), "Lazy K Kountry Store");
        }

        [TestMethod]
        public void When_Linq95_Called_Should_Assert_false()
        {
            var result = _miscellaneousOperators.Simple95();
            Assert.AreNotEqual(result.First(), "Haci Sait");
        }

        [TestMethod]
        public void When_Linq96_Called_Should_Assert_true()
        {
            var result = _miscellaneousOperators.Simple96();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void When_Linq96_Called_Should_Assert_false()
        {
            var result = _miscellaneousOperators.Simple96();
            Assert.AreNotEqual(result, false);
        }

        [TestMethod]
        public void When_Linq97_Called_Should_Assert_true()
        {
            var result = _miscellaneousOperators.Simple97();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void When_Linq97_Called_Should_Assert_false()
        {
            var result = _miscellaneousOperators.Simple97();
            Assert.AreNotEqual(result, true);
        }
    }
}
