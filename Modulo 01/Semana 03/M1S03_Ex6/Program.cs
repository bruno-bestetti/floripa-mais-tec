/*
Crie um exemplo de Console App utilizando os modificadores de acesso: Internal(classes), Private, Protected e Private (atributos e métodos)

-- Por fim, na classe Program.cs:
-- Instancie um objeto de produto:

** Produto produto1 = new Produto();
Atribua valores neste objeto e invoque os métodos que tenha permissão de acessar:
produto1.nome = "Calculadora";

** produto1.verificarEstoque();
Console.WriteLine("O nome do produto é: " + produto1.nome);

** Depois, instancie um objeto da classe ProdutoFinanceiro
ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

** Atribua valores aos atributos com permisão e invoque os métodos que a classe Program tenha permissão:
classeFilha.nome = "Produto Financeiro";
classeFilha.verificarEstoque();
classeFilha.acesso();

** Desta forma, você utilizou os moficicadores de acesso Public, Internal, Private e Protected.
*/

using M1S03_Ex6;

Produto produto = new Produto();
produto.nome = "Poupança";
produto.VerificarEstoque();
Console.WriteLine("O nome do produto é: " + produto.nome);

ProdutoFinanceiro produtoFinanceiro = new ProdutoFinanceiro();
produtoFinanceiro.nome = "Debenture";
produtoFinanceiro.VerificarEstoque();
produtoFinanceiro.Acesso();
