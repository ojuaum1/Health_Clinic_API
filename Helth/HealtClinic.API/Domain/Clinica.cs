using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealtClinic.API.Domain
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereço oBrigatorio!")]
        public string Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "CNPJ Obrigatorio!")]
        public string CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Razao social obrigatoria")]
        public string RazaoSocial { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Horario Obrigatorio!")]
        public TimeOnly HorarioAbertura { get; set; }

        [Column(TypeName = "TiME")]
        [Required(ErrorMessage = "Horario Obrigatorio!")]
        public TimeOnly HorarioEncerramento { get; set; }
    }
}
