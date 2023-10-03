using HealtClinic.API.Domain;
using HealtClinic.API.Interface;
using webapi.event_.manha.Contexts;

namespace HealtClinic.API.Repository
{
    namespace webapi.event_.manha.Repositories
    {
        public class UsuarioRepository : IUsuarioRepository
        {
            private readonly HealthContext_healthContext;

            public UsuarioRepository()
            {
                _healthContext = new HealthContext();
            }


            public Usuario BuscarPorEmailEsenha(string email, string senha)
            {
                try
                {
                    Usuario usuarioBuscado = _healthContext.Usuarios
                        .Select(u => new Usuario
                        {
                            IdUsuario = u.IdUsuario,
                            Nome = u.Nome,
                            Email = u.Email,
                            Senha = u.Senha,
                            TipoUsuario = new TipoUsuario
                            {
                                IdTipoUsuario = u.TipoUsuario.IdTipoUsuario
                            }
                        }).FirstOrDefault(u => u.Email == email)!;

                    if (usuarioBuscado != null)
                    {
                        bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                        if (confere)
                        {
                            return usuarioBuscado;
                        }
                    }
                    return null!;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public Usuario BuscarPorId(Guid Id)
            {
                try
                {
                    Usuario UsuarioBuscado = _healthContext.Usuarios
                        .Select(u => new Usuario
                        {
                            IdUsuario = u.IdUsuario,
                            Nome = u.Nome,

                            TipoUsuario = new TipoUsuario
                            {
                                titulo = u.TipoUsuario!.titulo
                            }
                        }).FirstOrDefault(u => u.IdUsuario == Id)!;

                    if (UsuarioBuscado != null)
                    {
                        return UsuarioBuscado;
                    }
                    return null!;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void Cadastrar(Usuario usuario)
            {
                try
                {
                    usuario.Senha = Criptografia.GerarHash(usuario.Senha);

                    _healthContext.Usuarios.Add(usuario);

                    _healthContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
             
             public void Deletar(string email, string senha)
        {
            try
            {
                Usuario usuarioDeletado = _healthContext.Usuario.FirstOrDefault(z => z.Email == email)!;

                if (usuarioDeletado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioDeletado.Senha!);

                    if (confere)
                    {
                        _healthContext.Usuario.Remove(usuarioDeletado);
                        _healthContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
