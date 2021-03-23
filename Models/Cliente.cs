using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace  SistemaAdminTaller.Models
{    
    public class Cliente
    {
        [Key]
        public Guid ID {get; set;}

        [MaxLength(200)]
        [Required(ErrorMessage="El nombre es requerido")]
        public string Nombre {get ;set;}

        [MaxLength(200)]
        [Required(ErrorMessage="El apellido es requerido")]
        public string Apellido {get; set;}

        [MaxLength(200)]
        public string Dirección {get; set;}

        [Required(ErrorMessage="El telefono es requerido")]
        [MaxLength(50)]
        public string Telefono {get; set;}

        [MaxLength(200)]
        public string Email {get; set;}
        // public List<Course> CourseStudent {get; set;}

        public List<Vehiculo> VehiculosCliente {get; set;}

        [NotMapped]
        public string NombreCompleto 
        {
            get{
                return Nombre + ' ' + Apellido;
            }
        }

    }
}
