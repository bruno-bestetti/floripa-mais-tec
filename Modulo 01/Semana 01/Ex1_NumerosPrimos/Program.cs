// Exercicio  01 - Semana 1 - Buscador de números primos

// array para armazenar os dez números que o usuário vai digitar
using System;

int[] Numeros = new int[10];

// para ler 10 vezes um número no console
for (int i = 0; i < 10; i++)
 {
    Console.Write($"Digite o {i + 1}º número: "); // precisamos somar + 1 por que que i inicia em 0
    Numeros[i] = Convert.ToInt32(Console.ReadLine());
 }


for (int i = 0; i < 10; i++)
{
    // o contador marca quantas vezes ele é divisível por um número menor que ele
    // Inicia em 1 porque todo número é divisível por 1
    int contador = 1;

    for (int n = 1; n < Numeros[i]; n++) // O C# não divide por 0, por isso começa em 1.
    {
        if (Numeros[i] % n == 0) // % é o resto da divisão do numero pelo contador
        {
            contador = contador++;

        }
    }

    if (contador == 2) // se o contador for 2, o numero é divisível somente por 0 e por ele mesmo, então é numero primo.
    {
        Console.WriteLine($"O número {Numeros[i]} é um número primo. Ela está na posição {i} do Array de números.");
    }
}




