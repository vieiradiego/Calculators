﻿using Calculadora.Classes.Calculadora;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Classes
{
    public class Sum : Operations
    {
        public Sum()
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
            if (expression.Contains('+'))
            {
                expression = expression.Substring(expression.IndexOf('+') + 1);
            }
            return expression;
        }
    }
}
