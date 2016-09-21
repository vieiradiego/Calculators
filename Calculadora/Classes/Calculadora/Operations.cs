using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora.Classes.Calculadora
{
    public class Operations : iCalculator
    {
        private double result;
        public double getResult()
        {
            return this.result;
        }
        public void setResult(double number)
        {
            this.result = number;
        }
        public virtual double operate(string number)
        {
            return this.getResult();
        }
        public virtual string getNumber(string expression)
        {
            return expression;
        }
    }
}
