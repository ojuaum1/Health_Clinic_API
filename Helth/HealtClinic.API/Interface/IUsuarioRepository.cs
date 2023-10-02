using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{

        public interface IUsuarioRepository
        {
            void Cadastrar(Usuario usuario);

            Usuario BuscarPorId(Guid Id);

            Usuario BuscarPorEmailEsenha(string email, string senha);
        }
    
}
