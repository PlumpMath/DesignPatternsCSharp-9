using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SimpleTaxCalculator
{
    public class USTaxCalculator : ITaxCalculator
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            double tax;
            if (conditions.Income < 2000)
                tax = conditions.Income * 0.05;
            else if (conditions.Income < 5000)
                tax = conditions.Income * 0.1;
            else if (conditions.Income < 10000)
                tax = conditions.Income * 0.15;
            else
                tax = conditions.Income * 0.20;

            tax += conditions.Income * 0.05;
            return Math.Round(tax, 2);
        }
    }
}
