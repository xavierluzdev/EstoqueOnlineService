using EstoqueOnlineService.Material.Maps;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Contexto
{
    public class MaterialContexto : DbContext
    {
        public virtual DbSet<Entidades.Material> Material { get; set; }
        public virtual DbSet<Entidades.ItemMaterial> ItemMaterial { get; set; }
        public virtual DbSet<Entidades.Categoria> Categoria { get; set; }
        public virtual DbSet<Entidades.Classificacao> Classificacao { get; set; }

        private MaterialContexto(DbContextOptions<MaterialContexto> options) : base(options)
        {
        }

        internal static MaterialContexto Create(DbContextOptions<MaterialContexto> options)
        {
            return new MaterialContexto(options);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            MaterialMap.createInstance(modelBuilder);
            ItemMaterialMap.createInstance(modelBuilder);
            CategoriaMap.createInstance(modelBuilder);
            ClassificacaoMap.createInstance(modelBuilder);
            MaterialRelacionamento.createInstance(modelBuilder);

            modelBuilder.HasDefaultSchema("dbo");

        }
    }
}
