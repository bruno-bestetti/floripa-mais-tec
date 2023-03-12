using System.Runtime.ConstrainedExecution;
using ExerciciosM1S03.Classes.Enum;

namespace ExerciciosM1S03
{
    public class ContaBancaria
    {
        // Exercício 03 altere a visibilidade de todos os atributos da classe ContaBancaria para serem agora campos privados.
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            // atribui os valores do construtor
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular; 
            _tipoConta = tipoConta;
        }

        // Exercício 04 crie um segundo construtor para a classe ContaBancaria recebendo apenas o:
        // nome do titular - string; tipo de conta - Enum;

        // Os outros atributos restante (numero e agencia) devem ser atribuídos valores aleatórios obedecendo a seguinte regra:
        // A agencia e numero devem conter 4 dígitos podendo variar entre 0000 até 9999;
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            Random random = new Random(); // Instancia uma classe Random para gerar número aleatórios

            // gera um número aleatório entre 0000 e 9999
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            // atribui os valores do construtor
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }
        /*
         Exercício 05 crie um método na classe ContaBancaria para realizar transferência de valores entre contas.

         Para isso, você deve receber como parâmetro os seguintes dados.
         Conta de destino - a conta bancária a ser enviado o valor;

         Valor a ser transferido   
         O valor a ser transferido precisa ser maior do que 0;
        O valor a ser transferido precisa ser menor ou igual ao saldo atual da conta;
        */

        public void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            _saldo = _saldo - valor;
           
            conta.Depositar(valor);
            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        // Os próximos métodos foram criados durante os exercícios da semana 02.
        
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }


        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                _saldo = _saldo - valor;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}