using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaAdminTaller.Models;

namespace SistemaAdminTaller.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vehiculo> Vehiculos {get; set;}
        public DbSet<Mecanico> Mecanicos {get; set;}
        public DbSet<Repuesto> Repuestos {get; set;}

    }
}
