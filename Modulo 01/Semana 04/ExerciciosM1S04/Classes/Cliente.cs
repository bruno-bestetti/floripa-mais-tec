using ExerciciosM1S04.Classes.Enum;

// EXERCICÍO 01 - Defina uma classe chamada Cliente com os seguintes atributos:
//nome - string;
//nascimento - Datetime;
//profissao - string;
//estadoCivil - string(você pode criar também um Enum caso prefira);
//tipoPessoa - enum (valores possíveis: FISICA, JURIDICA);

//Todos os atributos precisam ser propriedades sendo o Get public porém o Set sendo private.
//Ex: public string Nome { get; private set; }
//Crie também um construtor padrão recebendo todos os atributos como argumentos.


namespace ExerciciosM1S04.Classes
{
    public class Cliente
    {
        //----------------------- Exercício 01
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public TipoPessoaEnum TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }
    }
}