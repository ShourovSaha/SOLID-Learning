﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class TaxCalculator
    {
        public decimal Calculate(ITaxCalculator taxCalculatorObj)
        {
            return taxCalculatorObj.CalculateTaxAmount();
        }
    }
}
