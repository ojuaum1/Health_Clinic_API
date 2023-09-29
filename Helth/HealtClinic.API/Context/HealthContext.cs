using HealtClinic.API.Domain;
using Microsoft.EntityFrameworkCore;


namespace webapi.event_.manha.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Gestão> Gestãos { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE03-S15; Database=Health_clinic; User Id = sa; pwd = Senai@134; TrustServerCertificate=true;", x => x.UseDateOnlyTimeOnly());
            base.OnConfiguring(optionsBuilder);
        }
    }
}
