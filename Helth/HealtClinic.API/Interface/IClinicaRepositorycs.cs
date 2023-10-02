using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IClinicaRepositorycs
    {
        void Cadastrar(Clinica clinica);

        Clinica BuscarPorId(Guid Id);

      
    }
}
