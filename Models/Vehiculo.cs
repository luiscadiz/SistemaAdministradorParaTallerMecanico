using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace  SistemaAdminTaller.Models
{    
    public class Vehiculo
    {
        [Key]
        public Guid ID { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "La marca es requerida")]
        public string Marca { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "El modelo es requerido")]
        public string Modelo { get; set; }

        [Display(Name = "Fecha Entrada")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime FechaEntrada { get; set; }

        [Display(Name = "Fecha Salida")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaSalida { get; set; }

        [MaxLength(300)]
        [Required(ErrorMessage = "La averia es requerida")]
        public string Averia { get; set; }  

        public string Patente { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }
        public float Presupuesto { get; set; }
        
        public Guid? ClienteId {get; set;}
        public Cliente Cliente {get; set;}
        public Guid? MecanicoId {get;set;}
        public Mecanico Mecanico {get; set;}

    }
}