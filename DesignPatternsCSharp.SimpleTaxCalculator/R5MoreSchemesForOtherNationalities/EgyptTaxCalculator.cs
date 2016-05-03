using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    class EgyptTaxCalculator : ITaxCalculator
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            return conditions.Income * 0.05;
        }
    }
}
