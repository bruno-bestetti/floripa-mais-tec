using ExerciciosM1S04.Classes;

//EXERCÍCIO 02 - Defina uma classe chamada ContaBancaria com os seguintes atributos:
//numero - int;
//agencia - int;
//cliente - Cliente(classe criada no exercício 01);
//saldo - decimal - deve iniciar em 0;
//Todos os atributos precisam ser propriedades sendo o Get public porém o Set sendo protected.
//Ex: public decimal Saldo { get; protected set; }


namespace ExerciciosM1S04
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public decimal Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = 0;
            Cliente = cliente;
        }


 //Em seguida crie os seguintes métodos:
 //Sacar() - saca um valor;
 //Depositar() - deposita um valor;
 //Transferir() - transfere um valor;
 //ExibirSaldo() - exibe uma mensagem com o saldo atual;

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            Saldo = Saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }

            Console.WriteLine($"Valor de R$ {valor} depositado com sucesso!");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
            }

            Console.WriteLine($"Saque no valor de R$ {valor} realizado com sucesso!");
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {Saldo}");
        }
    }
}
