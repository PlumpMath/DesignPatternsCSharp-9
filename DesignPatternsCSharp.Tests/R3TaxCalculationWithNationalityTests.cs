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
            R3TaxCalculationWithNationality calculator = new R3TaxCalculationWithNationality();
            double income = 1000;
            DateTime birthDate = new DateTime(1988, 05, 20);
            TaxCalculationConditions conditions = new TaxCalculationConditions(income, Nationality.US,birthDate);
            double calculatedTaxes = calculator.calculate(conditions);
            double expectedTaxes = 2 * (income * 0.05);
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void NonUSCitizen()
        {
            R3TaxCalculationWithNationality calculator = new R3TaxCalculationWithNationality();
            double income = 1000;
            DateTime birthDate = new DateTime(1988, 05, 20);
            TaxCalculationConditions conditions = new TaxCalculationConditions(income, Nationality.Canada,birthDate);
            double calculatedTaxes = calculator.calculate(conditions);
            double expectedTaxes = (income * 0.05);
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }



    }
}
