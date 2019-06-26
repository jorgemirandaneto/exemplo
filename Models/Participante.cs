using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exemplo.Models
{
    [Table("participante", Schema = "develop")]
    public class Participante
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
    }
}