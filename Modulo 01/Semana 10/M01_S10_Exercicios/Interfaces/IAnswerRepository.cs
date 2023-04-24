using M01_S10_Exercicios.Models;

namespace M01_S10_Exercicios.Interfaces
{
    public interface IAnswerRepository
    {
        void Create(Answer Answer);
        List<Answer> List();
        Answer? GetById(int id);
        void Update(Answer Answer);
        void Delete(int id);
    }
}
