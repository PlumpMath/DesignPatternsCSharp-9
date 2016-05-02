using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.SimpleTaxCalculator;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class SimpleTaxCalculationTests
    {
        [TestMethod]
        public void IncomeLessThan2000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 1000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.05, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void IncomeEquals2000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 2000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.1, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }


        [TestMethod]
        public void IncomeBetween2000And5000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 3000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.1, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void IncomeEquals5000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 5000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.15, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void IncomeBetween5000And10000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 6000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.15, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void IncomeEquals10000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 10000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.20, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void IncomeMoreThan10000()
        {
            SimpleTaxCalculator.SimpleTaxCalculator calculator = new SimpleTaxCalculator.SimpleTaxCalculator();
            double income = 15000;
            double calculatedTaxes = calculator.calculate(income);
            double expectedTaxes = Math.Round(income * 0.20, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }
    }
}
