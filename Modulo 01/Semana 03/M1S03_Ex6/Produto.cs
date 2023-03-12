/*
-- Crie um classe Produto com o modificadores de acesso internal;
-- Dentro dessa classe Produto, coloque os atributos com os modificadores de acesso:
-- public string nome, protected string cor, private double peso e preço;
-- Ainda dentro da classe produto crie 3 métodos, sendo:

1. public verificarEstoque() {…};
Imprima uma mensagem em tela, dentro desse método. 
Exemplo de mensagem: “Verificando estoque, acessando o método da classe produto“;

2. protected vender() {…};
Imprima uma mensagem em tela, dentro desse método. 
Exemplo de mensagem: “Vendendo produto, acessando método vender da classe produto“;

3. private descartar() {…}
Imprima uma mensagem em tela, dentro desse método. 
Exemplo de mensagem: “Descartando o produto, acessando o método da classe produto“;

4. protected void alteraAtributosPrivados(double peso2, double preco) {…}
Alterar o valor da variável privada peso de escopo da classe Produto conforme o valor da variável peso2 que será enviado via parâmetro;
*/

namespace M1S03_Ex6
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;

        public Produto()
        {
        }
        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto.");
            Console.WriteLine();
        }

        protected void Vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
            Console.WriteLine();
        }

        private void Descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
            Console.WriteLine();
        }

        protected void AlteraAtributosPrivados(double peso2, double preco)
        {
            this.peso = peso2;
            Console.WriteLine("Variável peso de escopo da classe: " + peso);
        }

    }
}
