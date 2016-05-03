using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    interface ITaxCalculator
    {
         double calculate(TaxCalculationConditions conditions);
    }
}
