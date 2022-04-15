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

        public static double Operar(double Operando1, double Operando2, char operador)
        {
            char Aux = ValidarOperador(operador);
            double Retorno = 0;
            switch (Aux)
            {
                case '+':
                    Retorno = Operando1 + Operando2;
                    break;
                case '-':
                    Retorno = Operando1 - Operando2;
                    break;
                case '*':
                    Retorno = Operando1 * Operando2;
                    break;
                case '/':
                    if (Operando2 != 0)
                    {
                        Retorno = Operando1 / Operando2;
                    }
                    break ;
            }
            return Retorno;

        }
    }

    public class Operando
    {
        private double numero;

        //Constructor por defecto
        public Operando()
        {
            this.numero = 0;
        }

        private double ValidarOperando(string strNumero)
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
        
        

    }
}
