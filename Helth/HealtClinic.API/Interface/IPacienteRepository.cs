using HealtClinic.API.Domain;

namespace HealtClinic.API.Interface
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        Paciente BuscarPorId(Guid Id);

        Paciente BuscarPorEmailEsenha(string email, string senha);
    }
}
