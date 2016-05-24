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
            ITaxCalculator taxCalculator = null;
            //Strategy Pattern
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
