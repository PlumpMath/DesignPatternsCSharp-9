using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.SimpleTaxCalculator;
using DesignPatternsCSharp.SharedKernel;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requirement 1
            SimpleTaxCalculator calculator = new SimpleTaxCalculator();
            double income = 1000;
            EmployeeIncomeInfo incomeInfo = new EmployeeIncomeInfo(income);
            Console.WriteLine("asd");
        }
    }
}
