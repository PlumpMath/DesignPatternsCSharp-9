using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class MoreSchemesForOtherNationalities
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            double tax;
            DateTime SixMonthsEarlier = DateTime.Now.AddMonths(-6);
            if (conditions.JoiningDate > SixMonthsEarlier)
                return 0;
            ITaxCalculator taxCalculator = null;
           
            //Strategy Pattern
            if (conditions.Nationality == Nationality.US)
                taxCalculator = new USTaxCalculator();
            else if(conditions.Nationality == Nationality.Canada)
                taxCalculator = new CanadaTaxCalculator();
            else
                taxCalculator = new EgyptTaxCalculator();
            
            return taxCalculator.calculate(conditions);
        }
    }
}
