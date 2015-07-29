using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Classes.Calculadora;


namespace Calculadora.Classes.Calculadora
{
    public interface iCalculator
    {
        float getResult();
        void setResult(float number);
    }
}
