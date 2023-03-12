/* Ex 1 - Crie uma classe "Produto" que possui as seguintes propriedades:

Nome (string)
Preço (double)
Quantidade (int)

1.1) Crie um construtor que inicializa as propriedades "Nome", "Preço" e "Quantidade". 

Crie um construtor padrão que inicializa o nome como "Sem Nome",
O preço como 0 e a quantidade como 0.
*/


namespace M1S03_Ex1
{
    internal class Produto
    {

        public String nome;
        public double preco;
        public int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public Produto()
        {
            nome = "Sem nome";
            preco = 0;
            quantidade = 0;
        }
    }
}