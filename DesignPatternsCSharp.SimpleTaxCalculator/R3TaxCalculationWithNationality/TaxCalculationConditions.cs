using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class TaxCalculationConditions
    {
        public DateTime JoiningDate { get; private set; }
        public double Income { get; private set; }
        public Nationality Nationality { get; private set; }

        public TaxCalculationConditions(double income,DateTime joiningDate,Nationality nationality)
        {
            this.Income = income;
            this.JoiningDate = joiningDate;
            this.Nationality = nationality;
        }
    }
}
