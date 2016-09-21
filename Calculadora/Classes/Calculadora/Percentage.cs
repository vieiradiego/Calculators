using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes.Calculadora
{
    public class Percentage : Operations
    {
        private Operations oper;
        private Operations operation;
        public Percentage(Operations operation)
        {//Constructor method
            this.operation = operation;
        }
        public Operations getOper()
        {
            return this.operation;
        }
        public void setOper(Operations oper)
        {
            this.oper = oper;
        }
        public override double operate(string number)
        {
            try
            {
                string s = "";
                s = number.Substring(((number.IndexOf('x') + 1)), (number.Length - (number.IndexOf('x') - 2)));
                s = (double.Parse(s, CultureInfo.InvariantCulture.NumberFormat) / 100).ToString();
                s = s.Replace(',', '.');
                double temp = double.Parse(s, CultureInfo.InvariantCulture.NumberFormat);
                temp = getResult() * temp;
                this.setResult(operation.operate(Convert.ToString(temp)));
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
            return expression;
        }
    }
}
