using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Entidades
{
    public class Categoria
    {
        protected Categoria()
        {
            this.Materiais = new List<Material>();
        }
        internal static Categoria Create()
        {
            return new Categoria();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        //navegação
        public virtual ICollection<Material> Materiais { get; set; } 
    }
}
