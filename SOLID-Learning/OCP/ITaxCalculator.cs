using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface ITaxCalculator
    {
        public decimal Income { get; set; }
        public decimal Deduction { get; set; }
        public decimal CalculateTaxAmount();
    }
}
