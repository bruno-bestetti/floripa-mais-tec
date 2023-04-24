// EXERCÍCIO 01
//Crie um programa que solicite ao usuário que insira dois números decimais.
//Em seguida, divida o primeiro número pelo segundo número;
//Se a divisão for bem-sucedida, exiba o resultado da divisão;

//Se a divisão não for bem-sucedida por meio do tratamento de exceções, faça:

int x = 0;
int y = 0;

try
{
    Console.Write("Digite o primeiro número: ");
    x = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    y = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da divisão é igual a: {x / y}");
}

catch (DivideByZeroException ex_zero)
{
    //Caso o usuário digite um valor 0, exiba uma mensagem de erro informando que não é possível dividir por zero (DivideByZeroException);
    Console.WriteLine($"Explicação do erro de divisão por zero: {ex_zero.Message}");
}

catch (FormatException ex_format)
{
    //Caso o usuário digite letras, exiba uma mensagem de erro informando que letras não podem ser informadas (FormatException);
    Console.WriteLine($"Explicação do erro de formato: {ex_format.Message}");
}
catch (Exception ex)
{
    //Caso aconteça algo inesperado, exiba uma mensagem de erro informando que ocorreu um erro (Exception);
    Console.WriteLine(ex.Message);
}

finally
{
    //Adicione o finally, atribua o valor 0 para as duas variáveis utilizadas para armazenador os números que o usuário digitou;
    x = 0;
    y = 0;
}