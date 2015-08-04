using Calculadora.Classes.Calculadora;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    public class Multiplication : Operations
    {
        public Multiplication()
        {//Constructor method
            
        }
        public override float operate(string number)
        {
            try
            {
                this.setResult(this.getResult() * float.Parse(number, CultureInfo.InvariantCulture.NumberFormat));
                return this.getResult();
            }
            catch (CalculatorException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public override string getNumber(string expression)
        {
            if (expression.Contains('x'))
            {
                expression = expression.Substring(expression.IndexOf('x') + 1);
            }
            return expression;
        }
    }
}
