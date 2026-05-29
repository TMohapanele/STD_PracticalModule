using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollSystem;

namespace PayrollSystemTests
{
    [TestClass]
    public class PayrollCalculatorTests
    {
        private PayrollCalculator calculator;

        public TestContext TestContext { get; set; }

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
        public void ClaculatedUIF_ShouldReturnCorrectValue()
        {
            decimal grossPay = 19000m;

            decimal expected = 190m;

            decimal actual = calculator.CalculateUIF(grossPay);
            TestContext.WriteLine($"Expected: {expected}");
            TestContext.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Membership")]
        public void CalculateMembership_ShouldReturnCorrectValue()
        {
            decimal grossPay = 19000m;

            decimal expected = 2470m;

            decimal actual = calculator.CalculateMembership(grossPay);
            TestContext.WriteLine($"Expected: {expected}");
            TestContext.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }

    }
}
