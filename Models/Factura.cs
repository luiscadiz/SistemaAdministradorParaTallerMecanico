using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaAdminTaller.Models
{
    public class Factura
    {
        [Key]
        public Guid ID { get; set; }

        public Guid? ClienteId {get; set;}
        public Cliente Cliente {get; set;}
        public Guid? VehiculoId{ get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Guid? RepuestoId { get; set; }
        public Repuesto Repuesto {get; set;}
        public float Total { get; set; }
        
        


        
        
        
        
    }
}