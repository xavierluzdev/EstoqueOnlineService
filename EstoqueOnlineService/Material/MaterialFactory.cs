using EstoqueOnlineService.Banco;
using EstoqueOnlineService.Material.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material
{
    public class MaterialFactory
    {
        private MaterialFactory() { }

        public MaterialContexto getContexto()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MaterialContexto>();
            optionsBuilder.UseSqlServer(SqlServerFactory.Create().getConnection());
            return MaterialContexto.Create(optionsBuilder.Options);
        }
        public static MaterialFactory Create()
        {
            return new MaterialFactory();
        }
        public Entidades.Categoria getCategoria()
        {
            return Entidades.Categoria.Create();
        }

        public Entidades.Material getMaterial()
        {
            return Entidades.Material.Create();
        }
        public Entidades.ItemMaterial getItemMaterial()
        {
            return Entidades.ItemMaterial.Create();
        }
    }
}
