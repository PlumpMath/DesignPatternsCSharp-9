using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SimpleSalaryCalculation
{
    public class SimpleSalaryCalculator
    {
        public double calculate(int hours,float hourRate)
        {
            return hours * hourRate;
        }
    }
}
