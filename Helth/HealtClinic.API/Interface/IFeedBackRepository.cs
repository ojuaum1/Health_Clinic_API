using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IFeedBackRepository
    {
        void Cadastrar(Feedback feedback);
        void Delete(Guid id);
        void Atualizar(Guid id, Feedback feedback);
    }
}
