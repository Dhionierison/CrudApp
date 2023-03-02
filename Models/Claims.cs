using Microsoft.Build.Framework;

namespace CrudApp.Models
{
    public class Claims
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
        public string? Type { get; set; }
        public string? Value { get; set; }
    }
}
