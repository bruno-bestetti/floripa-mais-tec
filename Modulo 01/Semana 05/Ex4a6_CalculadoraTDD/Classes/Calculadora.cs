using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercício 04
//Usando os conceitos de TDD e o framework NUnit, crie uma classe estática chamada  Calculadora
//que deverá conter os seguintes métodos:


//soma
//subtração
//multiplicação
//divisão
//Neste primeiro exercício considere apenas operações utilizando números inteiros.

namespace Ex4a6_CalculadoraTDD.Classes
{
    public static class Calculadora
    {
        /// <summary>
        /// Método para somar dois números inteiros
        /// </summary>
        /// <returns></returns>
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Método para subtrair dois números inteiros
        /// </summary>
        /// <returns></returns>
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Método para multiplicar dois números inteiros
        /// </summary>
        /// <returns></returns>
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Método para dividir dois números inteiros
        /// </summary>
        /// <returns></returns>
        public static int Dividir(int a, int b)
        {
            return a / b;
        }

        //Exercício 05
        //Usando os conceitos de TDD e o framework NUnit,
        //crie sobrecargas para os métodos da classe Calculadora
        //que deverá possibilitar fazer operações com dados do tipo double, float, decimal e long.

        //Métodos decimal

        /// <summary>
        /// Método para somar dois números decimais
        /// </summary>
        /// <returns></returns>
        public static decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        /// <summary>
        /// Método para subtrair dois números decimais
        /// </summary>
        /// <returns></returns>
        public static decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        /// <summary>
        /// Método para multiplicar dois números decimais
        /// </summary>
        /// <returns></returns>
        public static decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        /// <summary>
        /// Método para dividir dois números decimais
        /// </summary>
        /// <returns></returns>
        public static decimal Dividir(decimal a, decimal b)
        {
            return a / b;
        }

        //Métodos double

        /// <summary>
        /// Método para somar dois números double
        /// </summary>
        /// <returns></returns>
        public static double Somar(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Método para subtrair dois números double
        /// </summary>
        /// <returns></returns>
        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Método para multiplicar dois números double
        /// </summary>
        /// <returns></returns>
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Método para dividir dois números double
        /// </summary>
        /// <returns></returns>
        public static double Dividir(double a, double b)
        {
            return a / b;
        }

        //Métodos float

        /// <summary>
        /// Método para somar dois números float
        /// </summary>
        /// <returns></returns>
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        /// Método para subtrair dois números float
        /// </summary>
        /// <returns></returns>
        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        /// <summary>
        /// Método para multiplicar dois números float
        /// </summary>
        /// <returns></returns>
        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        /// <summary>
        /// Método para dividir dois números float
        /// </summary>
        /// <returns></returns>
        public static float Dividir(float a, float b)
        {
            return a / b;
        }

        //Métodos long

        /// <summary>
        /// Método para somar dois números long
        /// </summary>
        /// <returns></returns>
        public static long Somar(long a, long b)
        {
            return a + b;
        }

        /// <summary>
        /// Método para subtrair dois números long
        /// </summary>
        /// <returns></returns>
        public static long Subtrair(long a, long b)
        {
            return a - b;
        }

        /// <summary>
        /// Método para multiplicar dois números long
        /// </summary>
        /// <returns></returns>
        public static long Multiplicar(long a, long b)
        {
            return a * b;
        }

        /// <summary>
        /// Método para dividir dois números long
        /// </summary>
        /// <returns></returns>
        public static long Dividir(long a, long b)
        {
            return a / b;
        }
    }
}
