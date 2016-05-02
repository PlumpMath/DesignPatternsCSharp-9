using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SimpleTaxCalculator
{
    public class SimpleTaxCalculator
    {

        public double calculate(double income)
        {
            double tax;
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
