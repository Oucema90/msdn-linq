using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class GenerationOperatorsTests
    {
        private GenerationOperators _generationOperators;

        [TestInitialize]
        public void Initialize()
        {
            _generationOperators = new GenerationOperators();
        }

        [TestMethod]
        public void When_Linq65_Called_Should_Assert_true()
        {
            var result = _generationOperators.Simple65();
            Assert.AreEqual(result.Count(), 50);
            Assert.AreEqual(result.First().Digit, "100");
        }

        [TestMethod]
        public void When_Linq65_Called_Should_Assert_false()
        {
            var result = _generationOperators.Simple65();
            Assert.AreNotEqual(result.Count(), 0);
        }

        [TestMethod]
        public void When_Linq66_Called_Should_Assert_true()
        {
            var result = _generationOperators.Simple66();
            Assert.AreEqual(result.First(), 7);
            Assert.AreEqual(result.Count(), 10);
        }

        [TestMethod]
        public void When_Linq66_Called_Should_Assert_false()
        {
            var result = _generationOperators.Simple66();
            Assert.AreNotEqual(result.Count(), 0);
        }
    }
}
