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
    public class CarrosMap : IEntityTypeConfiguration<Carros>
    {
        public void Configure(EntityTypeBuilder<Carros> builder)
        {
            builder.ToTable("Carros");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnType("MONEY")
                .HasColumnName("Valor");

           
        }
    }
}
