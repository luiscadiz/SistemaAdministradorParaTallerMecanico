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
        public DbSet<SistemaAdminTaller.Models.Cliente> Cliente { get; set; }

        //public DbSet<Cliente> Clientes { get; set; }


    }
}
