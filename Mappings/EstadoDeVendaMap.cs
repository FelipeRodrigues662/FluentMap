using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaDeCarrosFluentMap.Modelos;

namespace VendaDeCarrosFluentMap.Mappings
{
    public class EstadoDeVendaMap : IEntityTypeConfiguration<EstadoDeVenda>
    {
        //[Id] INT IDENTITY(1,1),
        //[Vendido] BIT DEFAULT(0),
        //[ClienteId] INT NOT NULL,
        public void Configure(EntityTypeBuilder<EstadoDeVenda> builder)
        {
            builder.ToTable("EstadoDeVenda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Vendido)
                .HasColumnName("Vendido")
                .HasColumnType("BIT")
                .HasDefaultValue(0);
        }
    }
}
