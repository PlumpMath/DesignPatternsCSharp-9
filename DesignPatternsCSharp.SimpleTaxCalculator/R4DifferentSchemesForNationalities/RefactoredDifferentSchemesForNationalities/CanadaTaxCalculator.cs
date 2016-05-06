using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class CanadaTaxCalculator : ITaxCalculator
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            double tax;
            if (conditions.JoiningDate == null)
                return 0;
            if (conditions.Income < 1500)
                tax = conditions.Income * 0.05;
            else if (conditions.Income < 3000)
                tax = conditions.Income * 0.1;
            else if (conditions.Income < 7000)
                tax = conditions.Income * 0.15;
            else
                tax = conditions.Income * 0.20;
            return Math.Round(tax, 2);
        }
    }
}
