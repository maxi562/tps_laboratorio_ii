using System;

namespace Entidades
{
    public static class Calculadora
    {   
        private static char ValidarOperador(char operador)
        {
            char Retorno = '+';
            if(operador =='/' || operador =='-' || operador == '*')
            {
                Retorno = operador;
            }

            return Retorno;
        }

        public static double Operar(string Operando1, string Operando2, char operador)
        {
            char Aux = ValidarOperador(operador);
            double AuxNum = Convert.ToDouble(Operando1);
            double AuxNum2 = Convert.ToDouble(Operando2);
            double Retorno = 0;
            
            switch (Aux)
            {
                case '+':
                    Retorno = AuxNum + AuxNum2;
                    break;
                case '-':
                    Retorno = AuxNum - AuxNum2;
                    break;
                case '*':
                    Retorno = AuxNum * AuxNum2;
                    break;
                case '/':
                    if (AuxNum2 != 0)
                    {
                        Retorno = AuxNum / AuxNum2;
                    }
                    else
                    {
                        Retorno = 0;
                    }
                    break ;
            }
            return Retorno;

        }
    }

    public class Operando
    {
        private double numero;

        public string Numero
        {
            set { numero = ValidarOperando(value); }
        }
        
        //Constructor por defecto
        public Operando()
        {
            this.numero = 0;
        }

        private static double ValidarOperando(string strNumero)
        {
            Double Retorno = 0;

            foreach(char c in strNumero)
            {
                if(c >= '0' && c <= '9')
                {
                    Retorno = Convert.ToDouble(c);
                }
            }

            return Retorno;
        }

        private static bool EsBinario (string binario)
        {
            bool Retorno = true;
            foreach(char ch in binario)
            {
                if(ch != '0' || ch != '1')
                {
                    Retorno = false;
                    break;
                }
            }

            return Retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            int n = 0;      
            string Retorno = "Valor inválido";

            if(EsBinario(binario))
            {
                for (int x = binario.Length - 1, y = 0; x >= 0; x--, y++)
                {
                    n += (int)(int.Parse(binario[x].ToString()) * Math.Pow(2, y));
                }

                return Convert.ToString(n);
                
            }
            else
            {
                return Retorno;
            }

           
         }
        
        public static string DecimalBinario (double numero)
        {
            int Auxiliar = (int)Math.Round(numero);
            string binario = "";
            string fallo = "Valor inválido";

            while(Auxiliar > 0)
            {
                binario = Auxiliar % 2 + binario;
                Auxiliar /= 2;
            }
            return binario;       
                        
        }

        public static string DecimalBinario(string numero)
        {
            double Auxiliar = Convert.ToDouble(numero);
            string binario = DecimalBinario(Auxiliar);

            return binario;
        }

    }
}
