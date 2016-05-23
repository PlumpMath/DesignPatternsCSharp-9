using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class R3TaxCalculationWithNationality
    {
        public double calculate(TaxCalculationConditions conditions)
        {   
            double tax;
            DateTime SixMonthsEarlier = DateTime.Now.AddMonths(-6);
            if (conditions.JoiningDate > SixMonthsEarlier)
                return 0;
            if (conditions.Income < 2000)
                tax = conditions.Income * 0.05;
            else if (conditions.Income < 5000)
                tax = conditions.Income * 0.1;
            else if (conditions.Income < 10000)
                tax = conditions.Income * 0.15;
            else
                tax = conditions.Income * 0.20;
            if (conditions.Nationality == Nationality.US)
                tax += conditions.Income * 0.05;
            return Math.Round(tax, 2);
        }
    }
}
