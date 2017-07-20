using System;
using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class GroupingOperatorsTests
    {
        private GroupingOperators _groupingOperators;

        [TestInitialize]
        public void Initialize()
        {
            _groupingOperators = new GroupingOperators();
        }

        [TestMethod]
        public void When_Linq40_Called_Should_Assert_true()
        {
            var result = _groupingOperators.Simple40();
            Assert.AreEqual(result.FirstOrDefault().Remainder,0);
        }

        [TestMethod]
        public void When_Linq40_Called_Should_Assert_false()
        {
            var result = _groupingOperators.Simple40();
            Assert.AreNotEqual(result.FirstOrDefault().Remainder,1);
        }

        [TestMethod]
        public void When_Linq41_Called_Should_Assert_true()
        {
            var result = _groupingOperators.Simple41();
            Assert.AreEqual(result.FirstOrDefault().FirstLetter, 'b');
        }

        [TestMethod]
        public void When_Linq41_Called_Should_Assert_false()
        {
            var result = _groupingOperators.Simple41();
            Assert.AreNotEqual(result.FirstOrDefault().FirstLetter, 'a');
        }

        [TestMethod]
        public void When_Linq42_Called_Should_Assert_true()
        {
            var result = _groupingOperators.Simple42();
            Assert.AreEqual(result.FirstOrDefault().Category, "Food");
        }

        [TestMethod]
        public void When_Linq42_Called_Should_Assert_false()
        {
            var result = _groupingOperators.Simple42();
            Assert.AreNotEqual(result.FirstOrDefault().Category, "Movie");
        }

        [TestMethod]
        public void When_Linq43_Called_Should_Assert_true()
        {
            var result = _groupingOperators.Simple43();
            Assert.AreEqual(result.FirstOrDefault().CompanyName, "Lazy K Kountry Store");
        }

        [TestMethod]
        public void When_Linq43_Called_Should_Assert_false()
        {
            var result = _groupingOperators.Simple43();
            Assert.AreNotEqual(result.FirstOrDefault().CompanyName, "Meublatex");
        }

        [TestMethod]
        public void When_Linq44_Called_Should_Assert_true()
        {
            var result = _groupingOperators.Simple44();
            Assert.AreEqual(result.FirstOrDefault().Key, "from");
        }

        [TestMethod]
        public void When_Linq44_Called_Should_Assert_false()
        {
            var result = _groupingOperators.Simple44();
            Assert.AreNotEqual(result.FirstOrDefault().Key, "form");
        }

        [TestMethod]
        public void When_Linq45_Called_Should_Assert_true()
        {
            var result = _groupingOperators.Simple45();
            Assert.AreEqual(result.FirstOrDefault().Key, "from");
        }

        [TestMethod]
        public void When_Linq45_Called_Should_Assert_false()
        {
            var result = _groupingOperators.Simple45();
            Assert.AreNotEqual(result.FirstOrDefault().Key, "FORM");
        }
    }
}
