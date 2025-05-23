using System.ComponentModel.DataAnnotations;

namespace atv1.Models
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public ICollection<Cidade>? Cidades { get; set; }
    }

}




