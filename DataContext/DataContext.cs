using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaDeCarrosFluentMap.Mappings;
using VendaDeCarrosFluentMap.Modelos;

namespace VendaDeCarrosFluentMap.DataContext
{
    public class SistemaDeVendaDeCarrosDataContext: DbContext
    {
        public DbSet<Carros> Cars { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EstadoDeVenda> EstadoDeVendas { get; set; }
        public DbSet<Modelo> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=FluentMap;trustServerCertificate=true;User Id=sa;Password=123456789");
            //options.LogTo(Console.WriteLine);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarrosMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ModeloMap());
            modelBuilder.ApplyConfiguration(new EstadoDeVendaMap());
        }
    }
}
