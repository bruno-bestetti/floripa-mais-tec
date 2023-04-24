using M01_S10_Exercicios.Models;

namespace M01_S10_Exercicios.Interfaces
{
    public interface ITeacherRepository
    {
        void Create(Teacher Teacher);
        List<Teacher> List();
        Teacher? GetById(int id);
        void Update(Teacher Teacher);
        void Delete(int id);
    }
}
