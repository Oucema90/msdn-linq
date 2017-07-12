using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class RestrictionOperatorsTests
    {
        private RestrictionOperators _restrictionOperators;

        [TestInitialize]
        public void Initialize()
        {
            _restrictionOperators = new RestrictionOperators();
        }

        [TestMethod]
        public void When_Linq1_Called_Should_Assert_true()
        {
            var result = _restrictionOperators.Simple1();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void When_Linq1_Called_Should_Assert_false()
        {
            var result = _restrictionOperators.Simple1();
            Assert.AreNotEqual(5, result.FirstOrDefault());
        }

        [TestMethod]
        public void When_Linq2_Called_Should_Assert_true()
        {
            var result = _restrictionOperators.Simple2();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void When_Linq2_Called_Should_Assert_false()
        {
            var result = _restrictionOperators.Simple2();
            Assert.AreNotEqual(0, result.LastOrDefault());
        }

        [TestMethod]
        public void When_Linq3_Called_Should_Assert_true()
        {
            var result = _restrictionOperators.Simple3();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void When_Linq3_Called_Should_Assert_false()
        {
            var result = _restrictionOperators.Simple3();
            var firstOrDefault = result.FirstOrDefault();
            if (firstOrDefault != null)
                Assert.AreNotEqual("Chef Anton\'s Gumbo Mix", firstOrDefault.Name);
        }

        [TestMethod]
        public void When_Linq4_Called_Should_Assert_true()
        {
            var result = _restrictionOperators.Simple4();
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void When_Linq4_Called_Should_Assert_false()
        {
            var result = _restrictionOperators.Simple4();
            var last = result.Last();
            if (last != null)
                Assert.AreNotEqual("Meublatex", last.CompanyName);
        }

        [TestMethod]
        public void When_Linq5_Called_Should_Assert_true()
        {
            var result = _restrictionOperators.Simple5();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void When_Linq5_Called_Should_Assert_false()
        {
            var result = _restrictionOperators.Simple5();
            var firstOrDefault = result.FirstOrDefault();
            if (firstOrDefault != null)
                Assert.AreNotEqual("four", firstOrDefault);
        }
    }
}
