using M01_S10_Exercicios.Interfaces;
using M01_S10_Exercicios.Models;
using Microsoft.AspNetCore.Mvc;
using static M01_S10_Exercicios.DTO.TeacherDTO;


namespace M01_S10_Exercicios.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherRepository _teacherRepository;


    public TeacherController(ITeacherRepository TeacherRepository)
    {
        _teacherRepository = TeacherRepository;
    }


    [HttpPost]
    public ActionResult<Teacher> Create(Teacher teacher)
    {
        _teacherRepository.Create(teacher);

        return CreatedAtAction(nameof(TeacherController), new { id = teacher.Id }, teacher);
    }


    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlteracaoTeacherDTO TeacherDTO)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        teacher.UserId = TeacherDTO.UserId;
        teacher.Department = TeacherDTO.Department;

        return CreatedAtAction(nameof(TeacherController.Get), new { id = teacher.Id }, teacher);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var teacher = _teacherRepository.List();
        return Ok(teacher);
    }


    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        return Ok(teacher);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteATeacher(int id)
    {
        var teacher = _teacherRepository.GetById(id);
        if (teacher == null)
        {
            return NotFound();
        }

        _teacherRepository.Delete(id);

        return NoContent();
    }
}
