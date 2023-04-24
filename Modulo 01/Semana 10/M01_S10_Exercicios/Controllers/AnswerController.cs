using M01_S10_Exercicios.Models;
using M01_S10_Exercicios.Interfaces;
using static M01_S10_Exercicios.DTO.AnswerDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace M01_S10_Exercicios.Controllers;

[ApiController]
[Route("[controller]")]
public class AnswerController : ControllerBase
{
    private readonly IAnswerRepository _answerRepository;


    public AnswerController(IAnswerRepository AnswerRepository)
    {
        _answerRepository = AnswerRepository;
    }

    [HttpPost]
    public ActionResult<Answer> Create(Answer answer)
    {
        _answerRepository.Create(answer);

        return CreatedAtAction(nameof(AnswerController), new { id = answer.Id }, answer);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlteracaoAnswerDTO AnswerDTO)
    {
        var answer = _answerRepository.GetById(id);

        if (answer == null)
            return NotFound();

        answer.Answers = AnswerDTO.Answers;
        answer.Score = AnswerDTO.Score;
        answer.Observation = AnswerDTO.Observation;

        return CreatedAtAction(nameof(AnswerController.Get), new { id = answer.Id }, answer);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var answers = _answerRepository.List();
        return Ok(answers);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var answer = _answerRepository.GetById(id);

        if (answer == null)
            return NotFound();

        return Ok(answer);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int id)
    {
        var answer = _answerRepository.GetById(id);
        if (answer == null)
        {
            return NotFound();
        }

        _answerRepository.Delete(id);

        return NoContent();
    }
}


