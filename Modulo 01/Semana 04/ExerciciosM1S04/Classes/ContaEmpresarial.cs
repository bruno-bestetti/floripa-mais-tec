using ExerciciosM1S04.Classes.Enum;
using ExerciciosM1S04.Classes;

//EXERCÍCIO 03
//Defina três classes sendo chamadas de ContaCorrente, ContaPoupanca e ContaEmpresarial
//que herdem da classe base ContaBancaria 
//e implementem o seu construtor enviando os atributos recebidos como parâmetro para o construtor base.

//Obs: Só pode ser criadas contas correntes ou poupança de cliente com tipoPessoa com valor FISICA.
//Da mesma forma que só podem ser criadas contas empresariais para clientes com tipoPessoa com valor JURIDICA.

// EXERCÍCIO 04
//Na classe ContaEmpresarial defina os seguintes atributos:
//LimiteEmprestimo - decimal;
//TaxaJuros - decimal;
//PossuiEmprestimo - bool;
//ValorUsado - decimal;
//CNPJ - string;
//Os atributos precisam ser propriedades sendo o Get public porém o Set sendo private.
//Ex: public decimal TaxaJuros { get; private set; }

//Altere o construtor padrão recebendo os atributos novos também como argumentos, exceto PossuiEmprestimo.

//EXERCÍCIO 5 -Na classe ContaEmpresarial defina os seguintes métodos:
//FazerEmprestimo() PagarEmprestimo()

namespace ExerciciosM1S04.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        //----------------------- Exercício 04
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal ValorUsado { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public string CNPJ { get; private set; }


        //----------------------- Exercício 04
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;

            // Exceção para validar o Tipo da pessoa jurídica.
            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }

        //----------------------- Exercício 05
        //realiza uma transação de empréstimo recebendo como parâmetro o valor do empréstimo.
        //O valor não pode ser maior do que o definido no atributo LimiteEmprestimo.
        //O valor recebido deve ser adicionado ao saldo.
        //Só é permitido um empréstimo por vez. Para realização de um novo deve ser feito o pagamento do anterior;
        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui um empréstimo ativo!");
                return;
            }

            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("O valor ultrapassa seu limite de empréstimo disponível!");
                return;
            }

            PossuiEmprestimo = false;
            base.Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {valor} realizado com sucesso!");
        }

        //----------------------- Exercício 05
        //realiza o pagamento do valor pegue por empréstimo adicionado a taxa de juros.
        //O empréstimo deve ser pago em valor integral.
        //O valor pago deve ser retirado do saldo;
        //a propriedade PossuiEmprestimo deve ser marcada como false;
        public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);
            if (total > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento!");
                return;
            }

            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine($"Empréstimo no valor total de R$ {total} pago com sucesso!");
        }

        //----------------------- Exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 1,00 por saque
            valor += 1;
            base.Sacar(valor);
        }

        //----------------------- Exercício 06
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,50 por transferência
            valor += 0.50M;
            base.Transferir(conta, valor);
        }
    }
}