using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Aluno
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public long Cep { get; set; }
    }
}
