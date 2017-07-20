using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class ConversionOperatorsTests
    {
        private ConversionOperators _conversionOperators;

        [TestInitialize]
        public void Initialize()
        {
            _conversionOperators = new ConversionOperators();
        }

        [TestMethod]
        public void When_Linq54_Called_Should_Assert_true()
        {
            var result = _conversionOperators.Simple54();
            Assert.AreEqual(result.FirstOrDefault(),4.1);
        }

        [TestMethod]
        public void When_Linq54_Called_Should_Assert_false()
        {
            var result = _conversionOperators.Simple54();
            Assert.AreNotEqual(result.Length,6);
        }

        [TestMethod]
        public void When_Linq55_Called_Should_Assert_true()
        {
            var result = _conversionOperators.Simple55();
            Assert.AreEqual(result.FirstOrDefault(),"apple");
        }

        [TestMethod]
        public void When_Linq55_Called_Should_Assert_false()
        {
            var result = _conversionOperators.Simple55();
            Assert.AreNotEqual(result.FirstOrDefault(),"cherry");
        }

        [TestMethod]
        public void When_Linq56_Called_Should_Assert_true()
        {
            var result = _conversionOperators.Simple56();
            Assert.AreEqual(result.FirstOrDefault().Key,"Bob");
        }

        [TestMethod]
        public void When_Linq56_Called_Should_Assert_false()
        {
            var result = _conversionOperators.Simple56();
            Assert.AreNotEqual(result.Count,1);
        }

        [TestMethod]
        public void When_Linq57_Called_Should_Assert_true()
        {
            var result = _conversionOperators.Simple57();
            Assert.AreEqual(result.Count(),2);
        }

        [TestMethod]
        public void When_Linq57_Called_Should_Assert_false()
        {
            var result = _conversionOperators.Simple57();
            Assert.AreNotEqual(result.FirstOrDefault(),null);
        }
    }
}
