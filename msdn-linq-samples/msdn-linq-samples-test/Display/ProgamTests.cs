using System;
using System.Linq;
using msdn_linq_samples.Display;
using msdn_linq_samples.Enums;
using msdn_linq_samples.Provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msdn_linq_samples_test.Display
{
    [TestClass]
    public class ProgamTests
    {
        [TestMethod]
        public void When_Calling_DisplayMenu_Should_DisplayMainMenuItems()
        {
            var mainMenuItems = DataProvider.GetLinqOperators();
            var linqOperatorses = mainMenuItems as LinqOperators[] ?? mainMenuItems.ToArray();
            Assert.AreEqual(linqOperatorses.Count(),14);
            Assert.AreEqual(linqOperatorses.First().DisplayName(), "1. Restriction Operators");
            Assert.AreEqual(linqOperatorses.Last().DisplayName(), "14. Join Operators");
        }
    }
}
