using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaDeCarrosFluentMap.Modelos;

namespace VendaDeCarrosFluentMap.Mappings
{
    public class ModeloMap : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            // Tabela
            builder.ToTable("Modelo");
            // ChavePrimaria
            builder.HasKey(x => x.Id);
            // Identity
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            //Propriedades
            builder.Property(x => x.Nome)
                .IsRequired()//NotNull
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(120);

            builder.Property(x => x.Ano)
                .IsRequired()//NotNull
                .HasColumnName("Ano")
                .HasColumnType("INT");

            builder.Property(x => x.Cor)
                .IsRequired()//NotNull
                .HasColumnName("Cor")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(40);
        }
    }
}
