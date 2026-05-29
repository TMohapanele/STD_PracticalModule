using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollSystem;

namespace PayrollSystemTests
{
    [TestClass]
    public class PayrollCalculatorTests
    {
        private PayrollCalculator calculator;

        public TestContext TestContext {get; set; }

        [TestInitialize]
        public void Setup()
        {
            calculator = new PayrollCalculator();
        }

        [TestMethod]
        [TestCategory("Gross Pay")]
        public void CalculateGrossPay_ShouldReturnCorrectValue()
        {
            decimal expected = 19000m; 
            decimal actual = calculator.CalculateGrossPay(20);

            TestContext.WriteLine($"Expected: {expected}");
            TestContext.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual); 

        }

        [TestMethod]
        [TestCategory("UIF")]
        
    }
}
