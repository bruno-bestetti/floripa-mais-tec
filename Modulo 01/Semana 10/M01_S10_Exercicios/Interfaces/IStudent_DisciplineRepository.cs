using M01_S10_Exercicios.Models;

namespace M01_S10_Exercicios.Interfaces
{
    public interface IStudent_DisciplineRepository
    {
        void Create(Student_Discipline Student_Discipline);
        List<Student_Discipline> List();
        Student_Discipline? GetById(int id);
        void Update(Student_Discipline Student_Discipline);
        void Delete(int id);
    }
}
