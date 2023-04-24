using M01_S10_Exercicios.Models;
using M01_S10_Exercicios.Interfaces;
using static M01_S10_Exercicios.DTO.DisciplineDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace M01_S10_Exercicios.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplineController : ControllerBase
{
    private readonly IDisciplineRepository _disciplineRepository;


    public DisciplineController(IDisciplineRepository DisciplineRepository)
    {
        _disciplineRepository = DisciplineRepository;
    }

    [HttpPost]
    public ActionResult<Discipline> Create(Discipline discipline)
    {
        _disciplineRepository.Create(discipline);

        return CreatedAtAction(nameof(DisciplineController), new { id = discipline.Id }, discipline);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlteracaoDisciplineDTO DisciplineDTO)
    {
        var discipline = _disciplineRepository.GetById(id);

        if (discipline == null)
            return NotFound();

        discipline.TeacherId = DisciplineDTO.TeacherId;
        discipline.NameDiscipline = DisciplineDTO.NameDiscipline;

        return CreatedAtAction(nameof(DisciplineController.Get), new { id = discipline.Id }, discipline);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var discipline = _disciplineRepository.List();
        return Ok(discipline);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var discipline = _disciplineRepository.GetById(id);

        if (discipline == null)
            return NotFound();

        return Ok(discipline);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int id)
    {
        var answer = _disciplineRepository.GetById(id);
        if (answer == null)
        {
            return NotFound();
        }

        _disciplineRepository.Delete(id);

        return NoContent();
    }
}

