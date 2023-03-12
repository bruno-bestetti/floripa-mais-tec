/*
Em seguida, crie uma classe "Program":
2.1)dentro dela crie um método Main()
2.2) instancia dois objetos da classe "Produto":
2.2.1) Um usando o construtor com argumentos e...
2.2.2) Outro usando o construtor padrão.
2.3) Imprima os valores das propriedades de cada objeto no terminal.
*/

using M1S03_Ex1;

public class Program 
{
    static void Main(string[] args) //2.1 Criar método Main()
    {
        // 2.2.1 usando o construtor com argumentos
        Produto produto1 = new Produto("TV LED 40'", 1499.99, 7);

        // 2.2.2 usando o construtor padrão
        Produto produto2 = new Produto();

        // 2.3 Imprimindo os valores das propriedades dos dois objetos no terminal
        Console.WriteLine("Produto 1:");
        Console.WriteLine("Nome: " + produto1.nome);
        Console.WriteLine("Preço: R$ " + produto1.preco);
        Console.WriteLine("Quantidade: " + produto1.quantidade);
        
        Console.WriteLine();
        Console.WriteLine("_________");
        Console.WriteLine();

        Console.WriteLine("Produto 2:");
        Console.WriteLine("Nome: " + produto2.nome);
        Console.WriteLine("Preço: " + produto2.preco);
        Console.WriteLine("Quantidade: " + produto2.quantidade);
    }
}