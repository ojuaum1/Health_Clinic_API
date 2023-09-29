using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? SoBreNome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? DataDeNascimento { get; set; }
        
        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "O Sexo é obrigatórioo")]
        public bool? Sexo { get; set; }

        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
