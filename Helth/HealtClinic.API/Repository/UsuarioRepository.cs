using HealtClinic.API.Domain;
using HealtClinic.API.Interface;
using webapi.event_.manha.Contexts;

namespace HealtClinic.API.Repository
{
    namespace webapi.event_.manha.Repositories
    {
        public class UsuarioRepository : IUsuarioRepository
        {
            private readonly EventContext _eventContext;

            public UsuarioRepository()
            {
                HealthContext = new HealthContext();
            }


            public Usuario BuscarPorEmailEsenha(string email, string senha)
            {
                try
                {
                    Usuario usuarioBuscado = HealthContext.Usuarios
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
                    Usuario UsuarioBuscado = _eventContext.Usuarios
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

                    _eventContext.Usuarios.Add(usuario);

                    _eventContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
