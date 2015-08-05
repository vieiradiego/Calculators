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
        public Percentage()
        {//Constructor method
        }
        public Operations getOper()
        {
            return this.oper;
        }
        public void setOper(Operations oper)
        {
            this.oper = oper;
        }
        public override double operate(string number)
        {
            try
            {
                double temp = double.Parse(number, CultureInfo.InvariantCulture.NumberFormat);
                temp = temp / 100;
                this.setResult(oper.operate(Convert.ToString(temp)));
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
