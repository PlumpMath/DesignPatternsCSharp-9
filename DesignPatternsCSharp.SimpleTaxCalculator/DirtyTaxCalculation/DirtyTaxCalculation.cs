using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class DirtyTaxCalculation
    {
        public double calculate(TaxCalculationConditions conditions)
        {
            double tax;
            //US
            if (conditions.Nationality == Nationality.US)
            {
                int years = DateTime.Now.Year - conditions.BirthDate.Year;
                if (years < 20)
                    tax = 0;
                else
                {
                    if (conditions.Income < 2000)
                        tax = conditions.Income * 0.05;
                    else if (conditions.Income < 5000)
                        tax = conditions.Income * 0.1;
                    else if (conditions.Income < 10000)
                        tax = conditions.Income * 0.15;
                    else
                        tax = conditions.Income * 0.20;
                    tax += conditions.Income * 0.05;
                }
            }
            //Canada
            else if(conditions.Nationality == Nationality.Canada)
            {
                    if (conditions.Income < 1500)
                        tax = conditions.Income * 0.05;
                    else if (conditions.Income < 3000)
                        tax = conditions.Income * 0.1;
                    else if (conditions.Income < 7000)
                        tax = conditions.Income * 0.15;
                    else
                        tax = conditions.Income * 0.20;
                
            }
            //EGYPT
            else
            {
                tax = conditions.Income * 0.05;
            }
            return Math.Round(tax, 2);
        }
    }
}
