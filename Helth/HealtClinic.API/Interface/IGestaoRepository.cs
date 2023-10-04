using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IGestaoRepository
    {
        void Cadastrar(Usuario usuario);
    }
}
