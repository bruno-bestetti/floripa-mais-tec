/*
-- Crie outra classe em sua aplicação chamada ProdutoFinanceiro:
-- Faça essa classe ser uma classe filha da classe Produto;

Crie um método chamado acesso() com modificador de acesso público. Dentro deste método:
Instancie um objeto;
Atribua um valor para nome e cor desse objeto;
Imprima em tela esses valores:

Exemplo: Console.WriteLine("Nome: " + PF1.nome + "Cor: " + PF1.cor);

Invoque os métodos:
PF1.vender();
PF1.verificarEstoque();
PF1.alteraAtributosPrivados(99, 100.0);


*/

namespace M1S03_Ex6
{
    internal class ProdutoFinanceiro : Produto
    {
        public ProdutoFinanceiro()
        {
        }

        public ProdutoFinanceiro(string nome, string cor) : base(nome, cor)
        {
        }

        public void Acesso()
        {
            ProdutoFinanceiro produto = new ProdutoFinanceiro("CDB", "Laranja");
            produto.Vender();
            produto.AlteraAtributosPrivados(90, 100.0);

        }
    }
}
