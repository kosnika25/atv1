using System.ComponentModel.DataAnnotations;

namespace atv1.Models
{
    public class Cliente
    {
        [Key]
        public int Codigo { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }

}
