﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora.Classes.Calculadora
{
    public class Inverter : Operations
    {
        public Inverter()
        {//Constructor method
        
        }
        public override float operate(string number)
        {
            try
            {
                this.setResult(this.getResult() + float.Parse(number, CultureInfo.InvariantCulture.NumberFormat));
                return this.getResult();
            }
            catch (CalculatorException e)
            {
                throw;
            }
        }
        public override string getNumber(string expression)
        {
            return expression;
        }
    }
}