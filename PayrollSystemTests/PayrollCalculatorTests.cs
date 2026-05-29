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
        public void CalculateUIF_ShouldReturnCorrectValue()
        {
            decimal grossPay = 19000m;

            decimal expected = 190m;
            decimal actual = calculator.CalculateUIF(grossPay);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Membership")]
        public void CalculateMembership_ShouldReturnCorrectValue()
        {
            decimal grossPay = 19000m;

            decimal expected = 2470m;
            decimal actual = calculator.CalculateMembership(grossPay);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("PAYE")]
        public void CalculatePAYE_ShouldReturnCorrectValue()
        {
            decimal grossPay = 19000m;
            int dependents = 2;

            decimal expected = 4203.75m;
            decimal actual = calculator.CalculatePAYE(grossPay, dependents);

            Assert.AreEqual(expected, actual, 0.01m);
        }

        [TestMethod]
        [TestCategory("Net Pay")]
        public void CalculateNetPay_ShouldReturnCorrectValue()
        {
            decimal grossPay = 19000m;
            decimal uif = 190m;
            decimal paye = 4203.75m;
            decimal membership = 2470m;

            decimal expected = 12136.25m;

            decimal actual = calculator.CalculateNetPay(
                grossPay,
                uif,
                paye,
                membership);

            Assert.AreEqual(expected, actual);
        }
    }
}