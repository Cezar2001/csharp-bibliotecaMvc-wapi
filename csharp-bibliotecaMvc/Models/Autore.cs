using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    public class Autore
    {
        [Key]
        public int AutoreID { get; set; }
        public string Nome { get; set; }
        public ICollection<Libro>? Libro { get; set; }
    }
}
