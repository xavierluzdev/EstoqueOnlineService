using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Maps
{
    internal class MaterialMap
    {
        private MaterialMap(ModelBuilder builder)
        {

            builder.Entity<Entidades.Material>()
                .ToTable("Material", "dbo");
            builder.Entity<Entidades.Material>()
                .HasKey(x => x.Id);
            builder.Entity<Entidades.Material>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<Entidades.Material>()
                .Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Entity<Entidades.Material>()
                .Property(x => x.Descricao)
                .HasMaxLength(500);
            builder.Entity<Entidades.Material>()
                .Property(x => x.Status)
                .HasMaxLength(2)
                .IsRequired()
                .HasDefaultValue("AT");
            builder.Entity<Entidades.Material>()
                .Property(p => p.CategoriaId)
                .IsRequired();
            builder.Entity<Entidades.Material>()
                .HasIndex(p => p.CategoriaId)
                .HasName("IDX_CategoriaMaterial")
                .HasFilter("[CategoriaId] IS NOT NULL");
        }

        internal static MaterialMap createInstance(ModelBuilder builder)
        {
            return new MaterialMap(builder);
        }
    }
}
