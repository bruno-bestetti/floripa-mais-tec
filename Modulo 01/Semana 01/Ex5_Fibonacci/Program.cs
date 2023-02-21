//Faça um algoritmo que receba um número inteiro que será a quantidade de números calculados pela sequência de Fibonacci.
//Em seguida, exiba a sequência no terminal.

//Ex: Se receber o número 7, você irá exibir a sequência “1 2 3 5 8 13 21” que contém ao todo 7 números.

//# 05 - Sequência de Fibonacci

int n;
int x = 1, y = 0, z = 0;

// lê a quantidade de número da sequência a ser exibidos
string number = Console.ReadLine();
n = int.Parse(number);

// cria a sequência de Fibonacci
for (int i = 0; i < n; i++)
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
Console.ReadLine();