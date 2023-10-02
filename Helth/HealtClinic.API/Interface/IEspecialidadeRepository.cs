using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);
        void Delete(Guid id);
    }
}
