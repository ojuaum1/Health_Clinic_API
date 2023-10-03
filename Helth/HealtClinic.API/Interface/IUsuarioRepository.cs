using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{

        public interface IUsuarioRepository
        {
            void Cadastrar(Usuario usuario);

            void Deletar(string email, string senha);
                
            Usuario BuscarPorEmailEsenha(string email, string senha);
        }
    
}
