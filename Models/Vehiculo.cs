using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace  SistemaAdminTaller.Models
{    
    public class Vehiculo
    {
        [Key]
        public Guid ID {get; set;}

        [MaxLength(200)]
        [Required]
        public string Modelo{get ;set;}

        [MaxLength(200)]
        [Required]
        public string Patente {get; set;}


    }
}