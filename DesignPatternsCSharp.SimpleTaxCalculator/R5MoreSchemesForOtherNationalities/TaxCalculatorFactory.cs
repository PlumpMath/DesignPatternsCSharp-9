using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class TaxCalculatorFactory
    {
        public static ITaxCalculator createCalculator(Nationality nationality)
        {
            ITaxCalculator taxCalculator;
            if (nationality == Nationality.US)
                taxCalculator = new USTaxCalculator();
            else if (nationality == Nationality.Canada)
                taxCalculator = new CanadaTaxCalculator();
            else
                taxCalculator = new EgyptTaxCalculator();
            return taxCalculator;
        }
    }
}
