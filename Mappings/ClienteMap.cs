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
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        { 
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()//NotNull
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(120);

            builder.Property(x => x.Telefone)
                .IsRequired()//NotNull
                .HasColumnName("Telefone")
                .HasColumnType("INT");
        }
    }
}
