using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    ///A linha de código acima serve para tornar a propriedade Email única. A declaração ocorre acima da classe

    public class Usuario
    {
        //primary key da minha tabela usuario
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        //defini o tipo de dado que é o email e o error message 
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? Email { get; set; }

        //defini o tipo de dado que é a Senha e o error message 
        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(200, MinimumLength = 6, ErrorMessage = "A senha deve conter de 6 a 20 caracteres")]
        public string? Senha { get; set; }

        //defini o tipo de dado que é o Nome e o error message 
        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string? Nome { get; set; }

        //defini o tipo de dado que é o sobrenome e o error message 
        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "O sobrenome é obrigatório")]
        public string? SobreNome { get; set; }

        // defini que usuarios tem referencia com TipoUsuarios
        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
