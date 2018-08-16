using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Maps
{
    internal class ItemMaterialMap
    {
        private ItemMaterialMap(ModelBuilder builder)
        {

            builder.Entity<Entidades.ItemMaterial>()
                .ToTable("ItemMaterial", "dbo");
            builder.Entity<Entidades.ItemMaterial>()
                .HasKey(x => x.Id);
            builder.Entity<Entidades.ItemMaterial>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<Entidades.ItemMaterial>()
                .Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Entity<Entidades.ItemMaterial>()
                .Property(x => x.Descricao)
                .HasMaxLength(500);
            builder.Entity<Entidades.ItemMaterial>()
                .Property(x => x.Status)
                .HasMaxLength(2)
                .IsRequired()
                .HasDefaultValue("AT");
            builder.Entity<Entidades.ItemMaterial>()
                .Property(p => p.MaterialId)
                .IsRequired();
            builder.Entity<Entidades.ItemMaterial>()
                .HasIndex(p => p.MaterialId)
                .HasName("IDX_ItemMaterialMaterial")
                .HasFilter("[MaterialId] IS NOT NULL");
        }

        internal static ItemMaterialMap createInstance(ModelBuilder builder)
        {
            return new ItemMaterialMap(builder);
        }
    }
}
