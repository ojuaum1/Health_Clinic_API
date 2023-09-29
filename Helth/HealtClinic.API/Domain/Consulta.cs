using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        //defini a primary key
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        public Guid IdProntuario { get; set; }

        [ForeignKey("IdProntuario")]
        public Prontuario? Prontuario { get; set; }


        public Guid IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public Paciente? Paciente { get; set; }


        public Guid IdMedico { get; set; }

        [ForeignKey("IdMedico")]
        public Medico? Medico { get; set; }

    }
}
