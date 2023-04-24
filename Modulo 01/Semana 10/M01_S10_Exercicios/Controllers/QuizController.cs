using M01_S10_Exercicios.Interfaces;
using M01_S10_Exercicios.Models;
using Microsoft.AspNetCore.Mvc;
using static M01_S10_Exercicios.DTO.QuizDTO;

namespace M01_S10_Exercicios.Controllers;

[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly IQuizRepository _quizRepository;


    public QuizController(IQuizRepository QuizRepository)
    {
        _quizRepository = QuizRepository;
    }

    [HttpPost]
    public ActionResult<Quiz> Create(Quiz quiz)
    {
        _quizRepository.Create(quiz);

        return CreatedAtAction(nameof(QuizController), new { id = quiz.Id }, quiz);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlteracaoQuizDTO QuizDTO)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        quiz.DisciplineId = QuizDTO.DisciplineId;
        quiz.Title = QuizDTO.Title;

        return CreatedAtAction(nameof(QuizController.Get), new { id = quiz.Id }, quiz);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var quiz = _quizRepository.List();
        return Ok(quiz);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        return Ok(quiz);
    }


    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuiz(int id)
    {
        var quiz = _quizRepository.GetById(id);
        if (quiz == null)
        {
            return NotFound();
        }

        _quizRepository.Delete(id);

        return NoContent();
    }
}

