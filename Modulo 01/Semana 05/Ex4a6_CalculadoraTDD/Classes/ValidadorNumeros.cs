using System;

namespace Ex4a6_CalculadoraTDD.Classes

public static class ValidadorDeNumeros
{

    public static bool NumeroPrimo(int numero)
    {
        {

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0 && numero != 2)
                {
                    return false;
                }
            }
            return true;

        }
    }

    public static bool ParImpar(int numero)
    {
        return numero % 2 == 0;
    }

    public static bool NumeroEhDivisivelPor(int PrimeiroNumero, int SegundoNumero)
    {
        return PrimeiroNumero % SegundoNumero == 0;
    }

}