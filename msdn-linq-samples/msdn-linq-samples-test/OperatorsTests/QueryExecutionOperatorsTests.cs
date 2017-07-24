using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class QueryExecutionOperatorsTests
    {
        private QueryExecutionOperators _queryExecutionOperators;

        [TestInitialize]
        public void Initialize()
        {
            _queryExecutionOperators = new QueryExecutionOperators();
        }

        [TestMethod]
        public void When_Linq99_Called_Should_Assert_true()
        {
            var result = _queryExecutionOperators.Simple99();
            Assert.AreEqual(result.First(), 6);
        }

        [TestMethod]
        public void When_Linq99_Called_Should_Assert_false()
        {
            var result = _queryExecutionOperators.Simple99();
            Assert.AreNotEqual(result.First(), 10);
        }

        [TestMethod]
        public void When_Linq100_Called_Should_Assert_true()
        {
            var result = _queryExecutionOperators.Simple100();
            Assert.AreEqual(result.First(), 6);
        }

        [TestMethod]
        public void When_Linq100_Called_Should_Assert_false()
        {
            var result = _queryExecutionOperators.Simple100();
            Assert.AreNotEqual(result.First(), 1);
        }

        [TestMethod]
        public void When_Linq101_Called_Should_Assert_true()
        {
            var result = _queryExecutionOperators.Simple101();
            Assert.AreEqual(result.Item1.Count(), 4);
            Assert.AreEqual(result.Item2.Count(), 10);
        }

        [TestMethod]
        public void When_Linq101_Called_Should_Assert_false()
        {
            var result = _queryExecutionOperators.Simple101();
            Assert.AreNotEqual(result.Item1.Count(), 10);
            Assert.AreNotEqual(result.Item2.Count(), 4);
        }
    }
}
