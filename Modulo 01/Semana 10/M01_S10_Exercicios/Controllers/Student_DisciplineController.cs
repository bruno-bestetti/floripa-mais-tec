using M01_S10_Exercicios.Interfaces;
using M01_S10_Exercicios.Models;
using Microsoft.AspNetCore.Mvc;
using static M01_S10_Exercicios.DTO.Student_DisciplineDTO;


namespace M01_S10_Exercicios.Controllers;

[ApiController]
[Route("[controller]")]
public class Student_DisciplineController : ControllerBase
{
    private readonly IStudent_DisciplineRepository _student_DisciplineRepository;


    public Student_DisciplineController(IStudent_DisciplineRepository Student_DisciplineRepository)
    {
        _student_DisciplineRepository = Student_DisciplineRepository;
    }

    [HttpPost]
    public ActionResult<Student_Discipline> Create(Student_Discipline student_discipline)
    {
        _student_DisciplineRepository.Create(student_discipline);

        return CreatedAtAction(nameof(Student_DisciplineController), new { id = student_discipline.Id }, student_discipline);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var student_Discipline = _student_DisciplineRepository.List();
        return Ok(student_Discipline);
    }


    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var student_Discipline = _student_DisciplineRepository.GetById(id);

        if (student_Discipline == null)
            return NotFound();

        return Ok(student_Discipline);
    }


    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlteracaoStudent_DisciplineDTO Student_DisciplineDTO)
    {
        var student_Discipline = _student_DisciplineRepository.GetById(id);

        if (student_Discipline == null)
            return NotFound();

        student_Discipline.StudentId = Student_DisciplineDTO.StudentId;
        student_Discipline.DisciplineId = Student_DisciplineDTO.DisciplineId;

        return CreatedAtAction(nameof(Student_DisciplineController.Get), new { id = student_Discipline.Id }, student_Discipline);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteStudent_Discipline(int id)
    {
        var student_Discipline = _student_DisciplineRepository.GetById(id);
        if (student_Discipline == null)
        {
            return NotFound();
        }

        _student_DisciplineRepository.Delete(id);

        return NoContent();
    }
}