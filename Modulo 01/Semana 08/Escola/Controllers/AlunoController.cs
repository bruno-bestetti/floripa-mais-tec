using Escola.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
// Exercício 07 - Crie a classe AlunoController para criar os endpoints referente ao Aluno.

// Exercício 08 -Crie um endpoint na controller de alunos para listar os alunos da API
//Este endpoint receberá um parâmetro: nome
//Ou seja, este método poderá filtrar os alunos por nome
//Caso não seja informado um nome, o método deverá retornar toda a lista.
//Observação: a pesquisa não deve considerar o case-sensitive
//Ou seja:
//Filtro: Ana, ou ana, ou ANA, ou AnA, deve-se retornar Ana.

// Exercício 09 - Crie um endpoint na controller de alunos para obter um aluno por Id
//Este endpoint receberá um parâmetro: id
//Além do endpoint também deverá ser criado um método na classe AlunoRepository para retornar o aluno por id.
//Caso não exista deve-se retornar o Status Code correto.

// Exercício 10 - Crie um endpoint na controller de alunos para criar um novo aluno
//Também deverá ser criado uma classe chamada CriacaoAlunoDto.cs
//Este classe deverá ter as propriedades necessárias para criação de um aluno.
//Essa classe deve ser usada como tipo do parâmetro de entrada do endpoint.
//Além do endpoint também deverá ser criado um método na classe AlunoRepository para criar o aluno.
//Todos os atributos do Aluno são obrigatórios e devem ser validados

//Exercício 11 - Crie um endpoint na controller de alunos para excluir um aluno
//O endpoint deverá receber o id do aluno como parâmetro.
//Além do endpoint também deverá ser criado um método na classe AlunoRepository para exclusão o aluno.

namespace Escola.Controllers;

[ApiController]
[Route("[nome]")]

public class AlunoController : ControllerBase
{
    [HttpGet]
    public IActionResult Listar(string Nome)
    {
        var Repositories = new AlunosRepository();
        var alunoModel = Repositories.ListarAlunos(Nome);

        return Ok(alunoModel);
    }


    [HttpGet]
    [Route("{id}")]
    public IActionResult Obter(int id)
    {
        if (id <= 0)
            return BadRequest("Id deve ser maior que zero");

        var repository = new AlunosRepository();
        var alunoModel = repository.ObterAluno(id);

        if (alunoModel == null)
            return NotFound();

        return Ok(alunoModel);
    }

    [HttpPost]
    public IActionResult Criar([FromBody] CriacaoAlunoDto dto)
    {

        var repository = new AlunosRepository();
        var alunoModel = repository.CriarAluno(dto);
        return CreatedAtAction(nameof(AlunoController.Obter), new { id = alunoModel.Id }, alunoModel);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir(int id)
    {

        var repository = new AlunosRepository();
        repository.ExcluirAluno(id);

        return NoContent();
    }

}