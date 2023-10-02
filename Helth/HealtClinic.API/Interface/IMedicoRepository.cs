using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        Medico BuscarPorId(Guid Id);

        Medico BuscarPorEmailEsenha(string email, string senha);
    }
}
