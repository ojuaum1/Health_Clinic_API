using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Gestão))]
    public class Gestão
    {
        [Key]
        public Guid IdGestão { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome oBrigatorio!")]
        public string? Nome { get; set; }

        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
