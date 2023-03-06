using System.Runtime.ConstrainedExecution;
using ExerciciosM1S02.Classes.Enum;

namespace ExerciciosM1S02.Classes
{
    public class ContaBancaria
    {
        // --------------- Exercício 03
        // Defina uma classe chamada ContaBancaria com os seguintes atributos: número, agência, nome do titular, saldo, tipo de conta.
        // saldo - deve iniciar em 0; tipo de conta - deve ser um Enum com duas opções válidas: CORRENTE ou POUPANCA;
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public TipoContaEnum tipoConta;

        // --------------- Exercício 04 - Crie um método para depositar valores na conta bancária.

        // Pontos importantes a serem observados:
        // O valor de depósito deve ser recebido como parâmetro no método;
        // O valor a ser depositado deve ser maior do que 0;
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        // --------------- Exercício 05
        // Crie um método dentro da classe ContaBancaria que permita fazer saque de valores nesta conta.
        
        // Pontos importantes a serem observados:
        // 1. O valor de saque deve ser recebido como parâmetro no método;
        // 2. O valor a ser sacado deve ser maior do que 0;
        // 3. O valor de saque não pode ser maior que o saldo atual da conta;

        public void Sacar(decimal valor) // 1. O valor de saque deve ser recebido como parâmetro no método;
        {
            if (valor <= 0) // 2. O valor a ser sacado deve ser maior do que 0;
            {
                Console.WriteLine("O valor precisa ser maior do que 0");

            }
            else if (valor > saldo) // 3. O valor de saque não pode ser maior que o saldo atual da conta;
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");

            }
            else // saque de valor da conta
            {
                saldo = saldo - valor;
            }
        }

        // --------------- Exercício 06
        // Crie um método dentro da classe ContaBancaria que o saldo atual da conta.
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}
