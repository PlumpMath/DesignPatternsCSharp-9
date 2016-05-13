using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation.R6DynamicSchemes
{
    abstract class TaxCalculator
    {
        protected List<SchemeCondition> SchemeConditions { get; private set; }
        protected double DefaultFactor { get; private set; }

        protected TaxCalculator(double defaultFactor)
        {
            SchemeConditions = new List<SchemeCondition>();
            this.DefaultFactor = defaultFactor;
        }
    
        protected double calculateScheme(TaxCalculationConditions calculationConditions)
        {
            bool handled = false;
            foreach(SchemeCondition schemeCondition in SchemeConditions)
            {
                double taxes = schemeCondition.Match(calculationConditions,ref handled);
                if (handled)
                    return taxes;
            }
            return calculationConditions.Income*DefaultFactor;
        }
    }
}
