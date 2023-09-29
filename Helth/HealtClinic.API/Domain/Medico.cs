using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Medico))]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome oBrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "especifique sua especialidade!")]
        public string? Especialidade { get; set; }

        public string? Salario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "CRM oBrigatorio!")]
        public string? CRM { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Idade oBrigatoria!")]
        public string? Idade { get; set; }

        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? TipoUsuario { get; set; }

        public Guid IdEspecialidade { get; set; }
        [ForeignKey("IdEspecialidade")]
        public Especialidade? Especialidades { get; set; }



    }
}
