using System.Linq;
using msdn_linq_samples.LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.OperatorsTests
{
    [TestClass]
    public class AggregateOperatorsTests
    {
        private AggregateOperators _aggregateOperators;

        [TestInitialize]
        public void Initialize()
        {
            _aggregateOperators = new AggregateOperators();
        }

        [TestMethod]
        public void When_Linq73_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple73();
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void When_Linq73_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple73();
            Assert.AreNotEqual(result, 5);
        }

        [TestMethod]
        public void When_Linq74_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple74();
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void When_Linq74_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple74();
            Assert.AreNotEqual(result, 10);
        }

        [TestMethod]
        public void When_Linq76_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple76();
            Assert.AreEqual(result.First().OrderCount, 2);
        }

        [TestMethod]
        public void When_Linq76_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple76();
            Assert.AreNotEqual(result.First(), 6);
        }

        [TestMethod]
        public void When_Linq77_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple77();
            Assert.AreEqual(result.First().ProductCount, 3);
        }

        [TestMethod]
        public void When_Linq77_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple77();
            Assert.AreNotEqual(result.First().ProductCount, 6);
        }

        [TestMethod]
        public void When_Linq78_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple78();
            Assert.AreEqual(result, 45);
        }

        [TestMethod]
        public void When_Linq78_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple78();
            Assert.AreNotEqual(result, 50);
        }

        [TestMethod]
        public void When_Linq79_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple79();
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void When_Linq79_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple79();
            Assert.AreNotEqual(result, 30);
        }

        [TestMethod]
        public void When_Linq80_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple80();
            Assert.AreEqual(result.First().TotalUnitsInStock, 2);
        }

        [TestMethod]
        public void When_Linq80_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple80();
            Assert.AreNotEqual(result.First().TotalUnitsInStock, 6);
        }

        [TestMethod]
        public void When_Linq81_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple81();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void When_Linq81_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple81();
            Assert.AreNotEqual(result, 9);
        }

        [TestMethod]
        public void When_Linq82_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple82();
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void When_Linq82_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple82();
            Assert.AreNotEqual(result, 10);
        }

        [TestMethod]
        public void When_Linq83_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple83();
            Assert.AreEqual(result.First().CheapestPrice, 1);
        }

        [TestMethod]
        public void When_Linq83_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple83();
            Assert.AreNotEqual(result.First().CheapestPrice, 6);
        }

        [TestMethod]
        public void When_Linq84_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple84();
            Assert.AreEqual(result.First().CheapestProducts.First().ProductName, "Perth Pasties");
        }

        [TestMethod]
        public void When_Linq84_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple84();
            Assert.AreNotEqual(result.First().CheapestProducts.First().ProductName, "Chai");
        }

        [TestMethod]
        public void When_Linq85_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple84();
            Assert.AreEqual(result.First().CheapestProducts.First().ProductName, "Perth Pasties");
        }

        [TestMethod]
        public void When_Linq85_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple84();
            Assert.AreNotEqual(result.First().CheapestProducts.First().ProductName, "Chai");
        }

        [TestMethod]
        public void When_Linq86_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple86();
            Assert.AreEqual(result, 9);
        }

        [TestMethod]
        public void When_Linq86_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple86();
            Assert.AreNotEqual(result, 4);
        }

        [TestMethod]
        public void When_Linq87_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple87();
            Assert.AreEqual(result.First().MostExpensivePrice, 9);
        }

        [TestMethod]
        public void When_Linq87_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple87();
            Assert.AreNotEqual(result.First().MostExpensivePrice, 0);
        }

        [TestMethod]
        public void When_Linq88_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple88();
            Assert.AreEqual(result.First().MostExpensiveProducts.First().ProductName, "Northwoods Cranberry Sauce");
        }

        [TestMethod]
        public void When_Linq88_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple88();
            Assert.AreNotEqual(result.First().MostExpensiveProducts.First().ProductName, "Alice Mutton");
        }

        [TestMethod]
        public void When_Linq89_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple89();
            Assert.AreEqual(result, 4.5);
        }

        [TestMethod]
        public void When_Linq89_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple89();
            Assert.AreNotEqual(result, 45);
        }

        [TestMethod]
        public void When_Linq90_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple90();
            Assert.AreEqual(result, 6, 66666666666667);
        }

        [TestMethod]
        public void When_Linq90_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple90();
            Assert.AreNotEqual(result, 4.5);
        }

        [TestMethod]
        public void When_Linq91_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple91();
            Assert.AreEqual(result.First().AveragePrice, 4);
        }

        [TestMethod]
        public void When_Linq91_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple91();
            Assert.AreNotEqual(result.First().AveragePrice, 6);
        }

        [TestMethod]
        public void When_Linq92_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple92();
            Assert.AreEqual(result, 88, 33081);
        }

        [TestMethod]
        public void When_Linq92_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple92();
            Assert.AreNotEqual(result, 90);
        }

        [TestMethod]
        public void When_Linq93_Called_Should_Assert_true()
        {
            var result = _aggregateOperators.Simple93();
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void When_Linq93_Called_Should_Assert_false()
        {
            var result = _aggregateOperators.Simple84();
            Assert.AreNotEqual(result, 100);
        }
    }
}
