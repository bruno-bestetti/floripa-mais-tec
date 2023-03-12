using ExerciciosM1S03;
using ExerciciosM1S03.Classes.Enum;

ContaBancaria conta1 = new ContaBancaria(1542, 1234, "Bruno Bestetti", TipoContaEnum.POUPANCA);
ContaBancaria conta2 = new ContaBancaria(1545, 1234, "Bruno de Souza", TipoContaEnum.POUPANCA);

// testando metodo depositar
conta1.Depositar(200);

conta1.Transferir(conta2,50);

// exibe o saldo da conta1
conta1.ExibirSaldo();
// deve retornar que o saldo é 150

// exibe o saldo da conta1
conta2.ExibirSaldo();
// deve retornar que o saldo é 50