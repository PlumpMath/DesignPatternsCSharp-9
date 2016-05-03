using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.SimpleTaxCalculator;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class TaxCalculationWithNationalityTests
    {
        [TestMethod]
        public void USCitizen()
        {
            TaxCalculationWithNationality calculator = new TaxCalculationWithNationality();
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income,joiningDate,Nationality.US);
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
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = (income * 0.05);
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }



    }
}
