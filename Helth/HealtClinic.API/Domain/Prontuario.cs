using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Prontuario))]
    public class Prontuario
    {
        //defini a primary key que é Id
        [Key]
        public Guid IdProntuario { get; set; } = Guid.NewGuid();

        //defini o tipo de dado
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome oBrigatorio!")]
        public string tituloDaConsulta{ get; set; }

        //defini o tipo de dado
        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "digite os dados aqui")]

        public string DescProntuario { get; set; }

    }
}
