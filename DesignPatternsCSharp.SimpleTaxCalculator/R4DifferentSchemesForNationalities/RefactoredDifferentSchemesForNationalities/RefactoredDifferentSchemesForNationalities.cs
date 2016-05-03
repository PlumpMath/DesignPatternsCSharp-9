using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class RefactoredDifferentSchemesForNationalities
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            double tax;
            DateTime SixMonthsEarlier = DateTime.Now.AddMonths(-6);
            if (conditions.JoiningDate > SixMonthsEarlier)
                return 0;
            ITaxCalculator taxCalculator = null;
            if (conditions.Nationality == Nationality.US)
            {
                taxCalculator = new USTaxCalculator();
            }
            else
            {
                taxCalculator = new CanadaTaxCalculator();
            }
            return taxCalculator.calculate(conditions);
        }
    }
}
