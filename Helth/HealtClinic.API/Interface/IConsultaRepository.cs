using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);
        void Delete(Guid id);
        List<Consulta> Listar();
        List<Consulta> ListarMinhaConsulta(Guid id);
        void Atualizar(Guid id, Consulta consulta);
    }
}
