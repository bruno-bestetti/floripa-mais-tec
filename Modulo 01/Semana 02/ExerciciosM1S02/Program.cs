using ExerciciosM1S02;
using ExerciciosM1S02.Classes;
using ExerciciosM1S02.Classes.Enum;

ContaBancaria conta = new ContaBancaria();

conta.numero = 1542;
conta.agencia = 1234;
conta.nomeDoTitular = "Bruno Bestetti";
conta.tipoConta = TipoContaEnum.POUPANCA;

// testando metodo depositar
conta.Depositar(1320);

// testando metodo sacar 
conta.Sacar(150);

// testando método exibir saldo
conta.ExibirSaldo();

