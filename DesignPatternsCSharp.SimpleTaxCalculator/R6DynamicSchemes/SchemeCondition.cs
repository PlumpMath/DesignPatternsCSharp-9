using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation.R6DynamicSchemes
{
    class SchemeCondition
    {
        public double? From { get; private set; }
        public double? To { get; private set; }
        public float Factor { get; private set; }

        public SchemeCondition(double? from,double? to,float factor)
        {
            this.From = from;
            this.To = to;
            this.Factor = factor;
        }   

        public double Match(TaxCalculationConditions conditions,ref bool handled)
        {
            double income = conditions.Income;
            if (From != null && To != null && income >= From && income <= To)
                handled = true;
            if (From == null && income <= To)
                handled = true;
            if (To == null && income >= From)
                handled = true;
            if (handled)
                return Math.Round(income*Factor, 2);
            return 0;
        }
    }
}
