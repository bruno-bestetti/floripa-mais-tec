//Exercício 04
//Crie uma classe chamada AlunoModel com as seguintes propriedades:
//Nome
//Data de nascimento
//AlunoModel deve herdar de BaseModel

namespace Escola.Models;
public class AlunoModel : BaseModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
}