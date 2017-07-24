using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class QuantifierOperatorsTests
    {
        public QuantifierOperators QuantifiersOperators { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            QuantifiersOperators = new QuantifierOperators();
        }

        [TestMethod]
        public void When_Linq67_Called_Should_Assert_true()
        {
            var result = QuantifiersOperators.Simple67();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void When_Linq67_Called_Should_Assert_false()
        {
            var result = QuantifiersOperators.Simple67();
            Assert.AreEqual(result,true);
        }

        [TestMethod]
        public void When_Linq69_Called_Should_Assert_true()
        {
            var result = QuantifiersOperators.Simple69();
            Assert.AreEqual(result.FirstOrDefault().Category, "Food");
        }

        [TestMethod]
        public void When_Linq69_Called_Should_Assert_false()
        {
            var result = QuantifiersOperators.Simple69();
            Assert.AreNotEqual(result.FirstOrDefault().Category, "Medecide");
        }

        [TestMethod]
        public void When_Linq70_Called_Should_Assert_true()
        {
            var result = QuantifiersOperators.Simple70();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void When_Linq70_Called_Should_Assert_false()
        {
            var result = QuantifiersOperators.Simple70();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void When_Linq72_Called_Should_Assert_true()
        {
            var result = QuantifiersOperators.Simple72();
            Assert.AreEqual(result.FirstOrDefault().Category, "Medecine");
        }

        [TestMethod]
        public void When_Linq72_Called_Should_Assert_false()
        {
            var result = QuantifiersOperators.Simple72();
            Assert.AreNotEqual(result.Count(), 0);
        }
    }
}
