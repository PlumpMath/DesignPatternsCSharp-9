using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.SimpleTaxCalculator;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class TaxCalculationWithJoiningDateTests
    {
        [TestMethod]
        public void EmployeeForLessThanSixMonths()
        {
            TaxCalculationWithJoiningDate calculator = new TaxCalculationWithJoiningDate();
            DateTime joiningDate = DateTime.Now.AddMonths(-3);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income,joiningDate);
            Assert.AreEqual(0, calculatedTaxes);
        }

        [TestMethod]
        public void EmployeeForExactlySixMonths()
        {
            TaxCalculationWithJoiningDate calculator = new TaxCalculationWithJoiningDate();
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income, joiningDate);
            Assert.AreNotEqual(0, calculatedTaxes);
        }

        [TestMethod]
        public void EmployeeForMoreThanSixMonths()
        {
            TaxCalculationWithJoiningDate calculator = new TaxCalculationWithJoiningDate();
            DateTime joiningDate = DateTime.Now.AddMonths(-12);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income, joiningDate);
            Assert.AreNotEqual(0, calculatedTaxes);
        }

    }
}
