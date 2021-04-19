using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            this.SetNumero =numero;
        }
        #endregion
        #region Setters
        public string SetNumero {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion
        #region Metodos
        private double ValidarNumero (string strNumero)
        {
            double num = 0;
            double.TryParse(strNumero, out num);
            return num;
        }
        private static bool EsBinario(string strNumero)
        {
            bool esBinario = true;
            char[] arrayBinario = new char[strNumero.Length];
            arrayBinario = strNumero.ToCharArray();
            foreach (char caracter in arrayBinario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    esBinario = false;
                }
            }
            return esBinario;
        }

        public static string DecimalABinario(double numero)
        {
            int numeroPositivo;
            string binary = "";

            numeroPositivo = Math.Abs((int) Math.Round(numero));
            // binary = Convert.ToString(numeroPositivo, 2);
            while (numeroPositivo > 1)
            {
                if (numeroPositivo % 2 == 0)
                {
                    binary = binary.Insert(0, "0");
                    numeroPositivo = numeroPositivo / 2;
                }
                else
                {
                    binary = binary.Insert(0, "1");
                    numeroPositivo = (numeroPositivo - 1) / 2;
                }
            }
            binary = binary.Insert(0, numeroPositivo.ToString());

            return binary;
        }

        public static string DecimalABinario (string strNumero)
        {
            double numero;
            string binario = "Valor Invalido";
            if(double.TryParse(strNumero, out numero))
            {
                binario = Numero.DecimalABinario(numero);
            }
            return binario;
        }
        public static string BinarioADecimal (string binario)
        {
            string numeroDecimal = "Valor invalido";
            if (EsBinario(binario))
            {
                //numeroDecimal = Convert.ToInt64(binario, 2).ToString();
                int numero = 0;

                int j = binario.Length - 1;
                for (int i = 0; i < binario.Length; i++)
                {
                    numero += (int) Math.Pow(2,j) * (int) char.GetNumericValue(binario[i]);
                    j--;
                }
                numeroDecimal = numero.ToString();
            }
            return numeroDecimal;
        }

        #endregion
        #region Operadores
        public static double operator + (Numero num1,Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            double result;
            if (num2.numero == 0)
            {
                result = double.MinValue;
            } else
            {
                result = num1.numero / num2.numero;
            }
            return result;
        }
        #endregion
    }
}
