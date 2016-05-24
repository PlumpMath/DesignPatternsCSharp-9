using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.TaxCalculation
{
    public class TaxCalculationConditions
    {
        public double Income { get; private set; }
        public Nationality Nationality { get; private set; }
        public DateTime BirthDate { get; private set; }


        public TaxCalculationConditions(double income,Nationality nationality,DateTime birthDate)
        {
            this.Income = income;
            this.Nationality = nationality;
            this.BirthDate = birthDate;
            
        }
    }
}
