using M01_S10_Exercicios.Interfaces;
using M01_S10_Exercicios.Models;
using Microsoft.AspNetCore.Mvc;
using static M01_S10_Exercicios.DTO.QuestionDTO;

namespace M01_S10_Exercicios.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly IQuestionRepository _questionRepository;


    public QuestionController(IQuestionRepository QuestionRepository)
    {
        _questionRepository = QuestionRepository;
    }

    [HttpPost]
    public ActionResult<Question> Create(Question Question)
    {
        _questionRepository.Create(Question);

        return CreatedAtAction(nameof(QuestionController), new { id = Question.Id }, Question);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlteracaoQuestionDTO QuestionDTO)
    {
        var question = _questionRepository.GetById(id);

        if (question == null)
            return NotFound();

        question.QuizId = QuestionDTO.QuizId;
        question.Enunciation = QuestionDTO.Enunciation;
        question.Weight = QuestionDTO.Weight;

        return CreatedAtAction(nameof(QuestionController.Get), new { id = question.Id }, question);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var question = _questionRepository.List();
        return Ok(question);
    }


    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var question = _questionRepository.GetById(id);

        if (question == null)
            return NotFound();

        return Ok(question);
    }


    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuestion(int id)
    {
        var question = _questionRepository.GetById(id);
        if (question == null)
        {
            return NotFound();
        }

        _questionRepository.Delete(id);

        return NoContent();
    }
}
