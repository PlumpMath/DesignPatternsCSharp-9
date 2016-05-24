using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class R5MoreSchemesForOtherNationalities
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            ITaxCalculator taxCalculator = TaxCalculatorFactory.createCalculator(conditions.Nationality);     
            return taxCalculator.calculate(conditions);
        }
    }
}
