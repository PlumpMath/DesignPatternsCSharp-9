using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SimpleTaxCalculator
{
    interface ITaxCalculator
    {
         double calculate(TaxCalculationConditions conditions);
    }
}
