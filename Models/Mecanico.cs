using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaAdminTaller.Models
{
    public class Mecanico
    {
        [Key]
        public Guid ID { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage="El nombre es requerido")]
        public string Nombre { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage="El nombre es requerido")]
        public string Apellido { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage="El nombre es requerido")]
        public string Telefono { get; set; }
        public long DNI { get; set; }
 
    }
}