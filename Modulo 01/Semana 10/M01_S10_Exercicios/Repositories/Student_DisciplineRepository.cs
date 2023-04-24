using M01_S10_Exercicios.Context;
using M01_S10_Exercicios.Models;
using M01_S10_Exercicios.Interfaces;

namespace M01_S10_Exercicios.Repositories;

public class Student_DisciplineRepository : IStudent_DisciplineRepository
{
    private readonly SchoolContext _context;

    public Student_DisciplineRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Student_Discipline Student_Discipline)
    {
        _context.Students_Disciplines.Add(Student_Discipline);
        _context.SaveChanges();
    }


    public List<Student_Discipline> List()
    {
        return _context.Students_Disciplines.ToList();
    }


    public Student_Discipline? GetById(int id)
    {
        return _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Student_Discipline Student_Discipline)
    {
        _context.Students_Disciplines.Update(Student_Discipline);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var Student_Discipline = GetById(id);
        _context.Students_Disciplines.Remove(Student_Discipline);
        _context.SaveChanges();

    }
}