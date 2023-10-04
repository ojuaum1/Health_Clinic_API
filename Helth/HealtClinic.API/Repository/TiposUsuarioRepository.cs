using HealtClinic.API.Domain;
using Microsoft.EntityFrameworkCore;
using webapi.event_.manha.Contexts;

namespace HealtClinic.API.Repository
{
    public class TiposUsuarioRepository
    {
        private readonly HealthContext _healthContext;

        public TiposUsuarioRepository()
        {
            _healthContext = new HealthContext();
        }

        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            TipoUsuario tipoBuscado = _healthContext!.TipoUsuarios.Find(id)!;

            if (tipoBuscado != null)
            {
                tipoBuscado.titulo = tipoUsuario.titulo;
            }
            _healthContext.TipoUsuarios.Update(tipoBuscado!);
            _healthContext.SaveChanges();
        }
        public void Cadastrar(TipoUsuario perfilNovo)
        {
            try
            {
                _healthContext.TipoUsuarios.Add(perfilNovo);
                _healthContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

 



    }


