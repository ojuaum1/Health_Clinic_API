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

        public Guid IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public Paciente? Paciente { get; set; }


        public Guid IdMedico { get; set; }

        [ForeignKey("IdMedico")]
        public Medico? Medico { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Prontuario Obrigatorio")]
        public string Prontuario { get; set; }

    }
}
