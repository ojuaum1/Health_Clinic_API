using HealtClinic.API.Domain;
using HealtClinic.API.Interface;
using webapi.event_.manha.Contexts;

namespace HealtClinic.API.Repository
{

    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext _healtClinic;

        public void Cadastrar(Paciente paciente)
        {
            if (paciente == null)
            {
                _healtClinic.Pacientes.Add(paciente!);
                _healtClinic.SaveChanges();
            }

        }
    }
}
