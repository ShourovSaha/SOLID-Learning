using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class TaxCalculatorForUS : ITaxCalculator
    {
        public decimal Income { get; set; }
        public decimal Deduction { get; set; }

        public decimal CalculateTaxAmount()
        {
            return ((Income - Deduction) * 40/100);
        }
    }
}
