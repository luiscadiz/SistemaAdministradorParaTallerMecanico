using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaAdminTaller.Models
{
    public class Repuesto
    {
        [Key]
        public Guid ID { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage="El nombre es requerido")]
        public string Nombre { get; set; }
        [MaxLength(400)]
        public string Descripcion { get; set; }

        [Required]
        public float Precio { get; set; }
        [Required]
        public int Cantidad {get; set;}
    }
}