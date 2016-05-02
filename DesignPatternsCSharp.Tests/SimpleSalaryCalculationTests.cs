using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsCSharp.SimpleTaxCalculator;
namespace DesignPatternsCSharp.Tests
{
    [TestClass]
    public class SimpleSalaryCalculationTests
    {
        [TestMethod]
        public void SimpleSalaryCalculationTest()
        {
            SimpleSalaryCalculation.SimpleSalaryCalculator salaryCalculator = new SimpleSalaryCalculation.SimpleSalaryCalculator();
            int hours = 200;
            float hourRate = 20;
            double expectedSalary = hourRate * hours;
            double  calculatedSalary = salaryCalculator.calculate(200, 20);
            Assert.AreEqual(expectedSalary, calculatedSalary);
        }
    }
}
