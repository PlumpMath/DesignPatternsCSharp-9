using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class TaxCalculationWithJoiningDate
    {
        public double calculate(double income,DateTime joiningDate)
        {
            double tax;
            DateTime SixMonthsEarlier = DateTime.Now.AddMonths(-6);
            if (joiningDate > SixMonthsEarlier)
                return 0;
            if (income < 2000)
                tax = income * 0.05;
            else if (income < 5000)
                tax = income * 0.1;
            else if (income < 10000)
                tax = income * 0.15;
            else
                tax = income * 0.20;
            return Math.Round(tax, 2);
        }
    }
}
