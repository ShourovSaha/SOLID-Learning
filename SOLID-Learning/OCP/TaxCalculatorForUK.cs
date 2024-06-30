using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class TaxCalculatorForUK : ITaxCalculator
    {
        public decimal Income { get; set; }
        public decimal Deduction { get; set; }

        public decimal CalculateTaxAmount()
        {
            return ((Income - Deduction) * 35 / 100);
        }
    }
}
