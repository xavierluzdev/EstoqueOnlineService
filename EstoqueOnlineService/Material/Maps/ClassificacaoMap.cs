using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Maps
{
    internal class ClassificacaoMap
    {
        private ClassificacaoMap(ModelBuilder builder)
        {

            builder.Entity<Entidades.Classificacao>()
                .ToTable("Classificacao", "dbo");
            builder.Entity<Entidades.Classificacao>()
                .HasKey(x => x.Id);
            builder.Entity<Entidades.Classificacao>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<Entidades.Classificacao>()
                .Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Entity<Entidades.Classificacao>()
                .Property(x => x.Descricao)
                .HasMaxLength(500);
            builder.Entity<Entidades.Classificacao>()
                .Property(x => x.Status)
                .HasMaxLength(2)
                .IsRequired()
                .HasDefaultValue("AT");
        }

        internal static ClassificacaoMap createInstance(ModelBuilder builder)
        {
            return new ClassificacaoMap(builder);
        }
    }
}
