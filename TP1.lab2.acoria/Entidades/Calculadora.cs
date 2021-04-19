using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if (operador != '/' && operador != '-' && operador != '*' && operador != '+')
            {
                operador = '+';
            }
                return operador;
        }

        public static double Operar(Numero num1,Numero num2,string operador)
        {
            char operadorValidado = Calculadora.ValidarOperador(operador[0]);
            double resultado = 0;

            switch (operadorValidado)
            {
                case '+': 
                    resultado = num1 + num2;
                break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }
    }
}
