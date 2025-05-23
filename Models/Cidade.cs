using System.ComponentModel.DataAnnotations;

namespace atv1.Models
{
    public class Cidade
    {
        [Key]
        public int Codigo { get; set; }

        public string NomeCidade { get; set; } = string.Empty;

        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }


}
