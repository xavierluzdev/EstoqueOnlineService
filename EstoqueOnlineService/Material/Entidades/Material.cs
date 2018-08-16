using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Entidades
{
    public class Material
    {
        protected Material()
        {
            this.ItemMateriais = new List<ItemMaterial>();
        }
        internal static Material Create()
        {
            return new Material();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        //Foreign Key
        public int CategoriaId { get; set; }
        //Foreign Key
        public int ClassificacaoId { get; set; }
        //Navegação
        public virtual ICollection<ItemMaterial> ItemMateriais { get; set; }
        //Navegação
        public virtual Categoria Categoria { get; set; }
        //Navegação
        public virtual Classificacao Classificacao { get; set; } 
    }
}
