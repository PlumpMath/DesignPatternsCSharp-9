using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.TaxCalculation;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class R2TaxCalculationWithJoiningDateTests
    {
        [TestMethod]
        public void EmployeeForLessThanSixMonths()
        {
            R2TaxCalculationWithJoiningDate calculator = new R2TaxCalculationWithJoiningDate();
            DateTime joiningDate = DateTime.Now.AddMonths(-3);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income,joiningDate);
            Assert.AreEqual(0, calculatedTaxes);
        }

        [TestMethod]
        public void EmployeeForExactlySixMonths()
        {
            R2TaxCalculationWithJoiningDate calculator = new R2TaxCalculationWithJoiningDate();
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income, joiningDate);
            Assert.AreNotEqual(0, calculatedTaxes);
        }

        [TestMethod]
        public void EmployeeForMoreThanSixMonths()
        {
            R2TaxCalculationWithJoiningDate calculator = new R2TaxCalculationWithJoiningDate();
            DateTime joiningDate = DateTime.Now.AddMonths(-12);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income, joiningDate);
            Assert.AreNotEqual(0, calculatedTaxes);
        }

    }
}
