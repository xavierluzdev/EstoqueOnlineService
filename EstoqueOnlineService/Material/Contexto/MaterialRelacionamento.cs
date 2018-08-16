using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Contexto
{
    internal class MaterialRelacionamento
    {
        private MaterialRelacionamento(ModelBuilder modelBuilder)
        {
            Create(modelBuilder);
        }

        internal static void createInstance(ModelBuilder modelBuilder)
        {
            new MaterialRelacionamento(modelBuilder);
        }
        private void Create(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Material>()
                .HasMany(x=> x.ItemMateriais)
                .WithOne(x=> x.Material)
                .HasForeignKey(x=> x.MaterialId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Entidades.Material>()
               .HasOne(x => x.Categoria)
               .WithMany(x => x.Materiais)
               .HasForeignKey(x => x.CategoriaId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Entidades.Material>()
               .HasOne(x => x.Classificacao)
               .WithMany(x => x.Materiais)
               .HasForeignKey(x => x.ClassificacaoId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
