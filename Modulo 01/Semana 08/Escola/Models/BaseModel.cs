namespace Escola.Models;

//Exercício 03 - Crie uma classe abstrata chamada BaseModel com as seguintes propriedades:
//Id
//DataDeInclusao
//DataDeAlteracao
public abstract class BaseModel
{
    public int Id { get; set; }
    public DateTime DataDeInclusao { get; set; }
    public DateTime? DataDeAlteracao { get; set; }
}