using ExerciciosM1S04.Classes.Enum;
using ExerciciosM1S04.Classes;

//EXERCÍCIO 03
//Defina três classes sendo chamadas de ContaCorrente, ContaPoupanca e ContaEmpresarial
//que herdem da classe base ContaBancaria 
//e implementem o seu construtor enviando os atributos recebidos como parâmetro para o construtor base.

//Obs: Só pode ser criadas contas correntes ou poupança de cliente com tipoPessoa com valor FISICA.
//Da mesma forma que só podem ser criadas contas empresariais para clientes com tipoPessoa com valor JURIDICA.

namespace ExerciciosM1S04.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        //----------------------- Exercício 03
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            // Exceção para validar o Tipo da pessoa física.
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        //----------------------- Exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,10 por saque
            valor += 0.10M;
            base.Sacar(valor);
        }

        //----------------------- Exercício 06
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,05 por transferência
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
}