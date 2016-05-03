using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.TaxCalculation;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class R4DifferentSchemesForNationalitiesTests
    {
        [TestMethod]
        public void USCitizenWithIncomeLessThan2000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 1000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income,joiningDate,Nationality.US);
            //tax scheme
            double expectedTaxes = income * 0.05;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void USCitizenWithIncomeEquals2000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 2000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.US);
            double expectedTaxes = income * 0.1;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }


        [TestMethod]
        public void USCitizenWithIncomeBetween2000And5000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 3000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.US);
            double expectedTaxes = income * 0.1;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void USCitizenWithIncomeEquals5000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 5000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.US);
            double expectedTaxes = income * 0.15;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void USCitizenWithIncomeBetween5000And10000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 6000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.US);
            double expectedTaxes = income * 0.15;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void USCitizenWithIncomeEquals10000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 10000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.US);
            double expectedTaxes = income * 0.20;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void USCitizenWithIncomeMoreThan10000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 15000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.US);
            double expectedTaxes = income * 0.20;
            // federal taxes
            expectedTaxes += income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }


        [TestMethod]
        public void OtherCitizenWithIncomeLessThan1500()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 1000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            //tax scheme
            double expectedTaxes = income * 0.05;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void OtherCitizenWithIncomeEquals1500()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 1500;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = income * 0.1;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }


        [TestMethod]
        public void OtherCitizenWithIncomeBetween1500And3000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 2000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = income * 0.1;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void OtherCitizenWithIncomeEquals3000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 3000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = income * 0.15;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void OtherCitizenWithIncomeBetween3000And7000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 5000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = income * 0.15;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void OtherCitizenWithIncomeEquals7000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 7000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = income * 0.20;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

        [TestMethod]
        public void OtherCitizenWithIncomeMoreThan7000()
        {
            DifferentSchemesForNationalities calculator = new DifferentSchemesForNationalities();
            double income = 7000;
            DateTime joiningDate = DateTime.Now.AddMonths(-6);
            double calculatedTaxes = calculator.calculate(income, joiningDate, Nationality.Canada);
            double expectedTaxes = income * 0.20;
            expectedTaxes = Math.Round(expectedTaxes, 2);
            Assert.AreEqual(expectedTaxes, calculatedTaxes);
        }

    }
}
