//using HealtClinic.API.Domain;
//using Microsoft.EntityFrameworkCore;
//using webapi.event_.manha.Contexts;

//namespace HealtClinic.API.Repository
//{
//    public class TiposUsuarioRepository
//    {
//        private readonly HealthContext eventContext;

//        public TiposUsuarioRepository()
//        {
//            HealthContext = new HealthContext();
//        }

//        public void Atualizar(Guid Id, TipoUsuario tiposUsuario)
//        {
//            throw new NotImplementedException();
//        }

//        public TipoUsuario BuscarPorId(Guid Id)
//        {
//            try
//            {
//                return _context.TiposUsuario.Find(id)!;
//            }
//            catch (Exception)
//            {
//                throw;
//            }

//        }

//        public void Cadastrar(TipoUsuario tiposUsuario)
//        {
//            eventContext.TipoUsuarios.Add(tiposUsuario);
//            eventContext.SaveChanges();

//        }



//    }

//}
