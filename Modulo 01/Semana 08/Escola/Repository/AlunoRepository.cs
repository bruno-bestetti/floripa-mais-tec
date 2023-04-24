// Exercício 05 - Crie uma classe chamada AlunosRepository.
//Essa classe deve ter uma lista estática privada de AlunoModel.cs, para futuramente ser manipulada.
//A ideia é que esta classe funcione como uma tabela do banco de dados já que neste semana não iremos abordar este assunto.
//Um atributo estático fica armazenado em memória enquanto a aplicação está sendo executada

using Escola.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Escola.Repository;

public class AlunosRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>()
    {
        new AlunoModel {Id = 1, Nome = "Jesus"},
        new AlunoModel {Id = 2, Nome = "Maria"},
        new AlunoModel {Id = 3, Nome = "José"},
        new AlunoModel {Id = 4, Nome = "Pedro"},
        new AlunoModel {Id = 4, Nome = "Paulo"}
    };
//Exercício 06 - Crie um método na classe AlunosRepository para listar os alunos da lista estática de alunos.
//Este método receberá um parâmetro: nome
//Ou seja, este método poderá filtrar os alunos por nome
//Caso não seja informado um nome, o método deverá retornar toda a lista.
//Observação: a pesquisa não deve considerar o case-sensitive
//Ou seja:
//Filtro: Ana, ou ana, ou ANA, ou AnA, deve-se retornar Ana.
    public List<AlunoModel> ListarAlunos(string filtroNome)
    {

        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(z => z.Nome.ToLower().Contains(filtroNome.ToLower()))
            .OrderBy(x => x.Nome)
            .ToList();
    }
    public AlunoModel? ObterAluno(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

    public AlunoModel AtualizarAluno(int Id, CriacaoAlunoDto dto)
    {
        var AlunoModel = ObterAluno(Id);
        lista.Remove(AlunoModel);

        AlunoModel.Nome = dto.Nome;
        lista.Add(AlunoModel);
        return AlunoModel;
    }
    public AlunoModel CriarAluno(CriacaoAlunoDto dto)
    {

        var alunoModel = new AlunoModel();
        alunoModel.Nome = dto.Nome;
        lista.Add(alunoModel);

        return alunoModel;
    }
    public void ExcluirAluno(int id)
    {
        var alunoModel = lista.FirstOrDefault(a => a.Id == id);

        if (alunoModel != null)
            lista.Remove(alunoModel);
    }
}