using M01_S10_Exercicios.Models;

namespace M01_S10_Exercicios.Interfaces
{
    public interface IQuestionRepository
    {
        void Create(Question Question);
        List<Question> List();
        Question? GetById(int id);
        void Update(Question Question);
        void Delete(int id);
    }
}
