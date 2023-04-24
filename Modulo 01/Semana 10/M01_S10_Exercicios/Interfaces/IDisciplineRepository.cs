using M01_S10_Exercicios.Models;

namespace M01_S10_Exercicios.Interfaces
{
    public interface IDisciplineRepository
    {
        void Create(Discipline discipline);
        List<Discipline> List();
        Discipline? GetById(int id);
        void Update(Discipline discipline);
        void Delete(int id);
    }
}
