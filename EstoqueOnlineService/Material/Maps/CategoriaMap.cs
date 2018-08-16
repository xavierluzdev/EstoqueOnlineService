using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Maps
{
    internal class CategoriaMap
    {
        private CategoriaMap(ModelBuilder builder)
        {

            builder.Entity<Entidades.Categoria>()
                .ToTable("Categoria", "dbo");
            builder.Entity<Entidades.Categoria>()
                .HasKey(x => x.Id);
            builder.Entity<Entidades.Categoria>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<Entidades.Categoria>()
                .Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Entity<Entidades.Categoria>()
                .Property(x => x.Descricao)
                .HasMaxLength(500);
            builder.Entity<Entidades.Categoria>()
                .Property(x => x.Status)
                .HasMaxLength(2)
                .IsRequired()
                .HasDefaultValue("AT");
        }

        internal static CategoriaMap createInstance(ModelBuilder builder)
        {
            return new CategoriaMap(builder);
        }
    }
}
