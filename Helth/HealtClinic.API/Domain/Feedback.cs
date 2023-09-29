using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Feedback))]
    public class Feedback
    {
        [Key]
        public Guid IdFeedback { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome oBrigatorio!")]
        public string? Nome { get; set; }
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }
        public Guid IdPaciente { get; set; }
        [ForeignKey("IdPaciente")]
        public Paciente? Paciente { get; set; }
        public Guid IdConsulta { get; set; }
        [ForeignKey("IdConsulta")]
        public Consulta? Consulta  { get; set; }

    }
}
