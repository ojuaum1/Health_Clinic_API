using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealtClinic.API.Domain
{
    [Table(nameof(TipoUsuario))]
    public class TipoUsuario
    {
        //defini a primary key que é o Id
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        // defini que o tipo de dado que o nome é e defini 
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome oBrigatorio!")]
        public string titulo { get; set; }


    }

}
