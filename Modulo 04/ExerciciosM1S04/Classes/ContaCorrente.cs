using ExerciciosM1S04.Classes.Enum;
using ExerciciosM1S04.Classes;

//EXERCÍCIO 03
//Defina três classes sendo chamadas de ContaCorrente, ContaPoupanca e ContaEmpresarial
//que herdem da classe base ContaBancaria 
//e implementem o seu construtor enviando os atributos recebidos como parâmetro para o construtor base.

//Obs: Só pode ser criadas contas correntes ou poupança de cliente com tipoPessoa com valor FISICA.
//Da mesma forma que só podem ser criadas contas empresariais para clientes com tipoPessoa com valor JURIDICA.


// EXERCÍCIO 06 - Sobrescrita de método na classe Conta Corrente, Conta Poupança e Conta Empresarial
//Nas classes ContaCorrente e ContaPoupanca sobrescreva os seguintes métodos:

//Sacar():
//Classe ContaCorrente - deve ser cobrada uma taxa de R$ 0,50 por cada saque;
//Classe ContaPoupanca - deve ser cobrada uma taxa de R$ 0,10 por cada saque;
//Classe ContaEmpresarial - deve ser cobrada uma taxa de R$ 1,00 por cada saque;

//Transferir():
//Classe ContaCorrente - deve ser cobrada uma taxa de R$ 0,25 por cada transferência;
//Classe ContaPoupanca - deve ser cobrada uma taxa de R$ 0,05 por cada transferência;
//Classe ContaEmpresarial - deve ser cobrada uma taxa de R$ 0,50 por cada transferência;

namespace ExerciciosM1S04.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        //----------------------- Exercício 03
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
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
            // Taxa de R$ 0,50 por saque
            valor += 0.50M;
            base.Sacar(valor);
        }

        //----------------------- Exercício 06
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,25 por transferência
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}