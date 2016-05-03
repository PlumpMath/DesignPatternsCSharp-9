using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SimpleTaxCalculator
{
    public class DifferentSchemesForNationalities
    {
        public double calculate(double income,DateTime joiningDate,Nationality nationality)
        {
            double tax;
            DateTime SixMonthsEarlier = DateTime.Now.AddMonths(-6);
            if (joiningDate > SixMonthsEarlier)
                return 0;
            if(nationality == Nationality.US)
            {
                if (income < 2000)
                    tax = income * 0.05;
                else if (income < 5000)
                    tax = income * 0.1;
                else if (income < 10000)
                    tax = income * 0.15;
                else
                    tax = income * 0.20;
                
                tax += income * 0.05;
                return Math.Round(tax, 2);
            }
            else
            {
                if (income < 1500)
                    tax = income * 0.05;
                else if (income < 3000)
                    tax = income * 0.1;
                else if (income < 7000)
                    tax = income * 0.15;
                else
                    tax = income * 0.20;
                return Math.Round(tax, 2);
            }
        }
    }
}
