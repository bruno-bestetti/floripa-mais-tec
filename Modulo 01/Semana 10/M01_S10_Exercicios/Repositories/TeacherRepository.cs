﻿using M01_S10_Exercicios.Context;
using M01_S10_Exercicios.Models;
using M01_S10_Exercicios.Interfaces;

namespace M01_S10_Exercicios.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly SchoolContext _context;

    public TeacherRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Teacher Teacher)
    {
        _context.Teachers.Add(Teacher);
        _context.SaveChanges();
    }


    public List<Teacher> List()
    {
        return _context.Teachers.ToList();
    }


    public Teacher? GetById(int id)
    {
        return _context.Teachers.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Teacher Teacher)
    {
        _context.Teachers.Update(Teacher);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var Teacher = GetById(id);
        _context.Teachers.Remove(Teacher);
        _context.SaveChanges();

    }
}