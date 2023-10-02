using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface ITipoUsuarioRepository
    {
        
            void Cadastrar(TipoUsuario TipoUsuario);
            void Delete(Guid id);
            List<TipoUsuario> Listar();
            TipoUsuario BuscarPorId(Guid id);
            void Atualizar(Guid id, TipoUsuario TipoUsuario);
        
    }
}
