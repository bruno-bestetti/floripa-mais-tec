using M01_S10_Exercicios.Models;

namespace M01_S10_Exercicios.Interfaces
{
    public interface IStudentRepository
    {
        void Create(Student Student);
        List<Student> List();
        Student? GetById(int id);
        void Update(Student Student);
        void Delete(int id);
    }
}
