using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.TaxCalculation;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class R3TaxCalculationWithNationalityTests
    {
        [TestMethod]
        public void USCitizen()
        {
            TaxCalculationWithNationality calculator = new TaxCalculationWithNationality();
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double income = 1000;
            TaxCalculationConditions conditions = new TaxCalculationConditions(income, joiningDate, Nationality.US);
            double calculatedTaxes = calculator.calculate(conditions);
            double expectedTaxes = 2 * (income * 0.05);
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void NonUSCitizen()
        {
            TaxCalculationWithNationality calculator = new TaxCalculationWithNationality();
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double income = 1000;
            TaxCalculationConditions conditions = new TaxCalculationConditions(income, joiningDate, Nationality.Canada);
            double calculatedTaxes = calculator.calculate(conditions);
            double expectedTaxes = (income * 0.05);
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }



    }
}
