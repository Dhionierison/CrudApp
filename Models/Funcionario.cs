using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class Funcionario
    {
     
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100), MinLength(5)]
        public String? Nome { get; set; }
        [Required]
        [MaxLength(10), MinLength(5)]
        public string? Funcao { get; set; }
        [Required]
        [DataType("Tipo diferente do padrão de Data")]
        public DateTime DataNascimento { get; set; }
    }
}
