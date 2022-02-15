using System;
using System.Collections.Generic;
using System.Text;

namespace Asignacion1MinorMondragon
{
    class Operaciones
    {
        
        public static string OperacionSeleccionada;
        public string Sumar(double valor1,double valor2)
        {
            double resultado = valor1 + valor2;
            return "El resultado es: " + resultado.ToString();
        }

        public string Restar(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;
            return "El resultado es: " + resultado.ToString(); ;
        }

        public string Multiplicar(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;
            return "El resultado es: " + resultado.ToString();
        }

        public string Dividir(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;
            return "El resultado es: " + resultado.ToString();
        }

        public string VerificarNumeroPrimo(int valor1)
        {
            //ciclo para verificar si el numero es primo, si el verificador es igual a 2 el numero es primo
            int verificador = 0;
            string resultado;
            
            for (int i = 1; i < (valor1 + 1); i++)
            {
                if(valor1 % i == 0)
                {
                    verificador++;
                }
            }
            if (verificador != 2)
            {
                resultado = "El numero no es primo";
            }
            else
            {
                resultado = "El numero es primo";
            }
            return resultado;
        }

        public string VerificarNumeroPalindromo(int valor1)
        {
            int residuo, suma = 0, numeroTemporal;
            numeroTemporal = valor1;
            while (valor1 > 0)
            {
                residuo = valor1 % 10;
                suma = (suma * 10) + residuo;
                valor1 = valor1 / 10;
            }
            if(numeroTemporal == suma)
            {
                return "El numero es palindromo";
            }
            else
            {
                return "El numero no es palindromo";
            }
        }
    }
}
