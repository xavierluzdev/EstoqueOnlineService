using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Entidades
{
    public class ItemMaterial
    {
        protected ItemMaterial()
        {

        }
        internal static ItemMaterial Create()
        {
            return new ItemMaterial();
        }
        public int Id { get; set; }
        //foreign key
        public int MaterialId { get; set; }
        //navegação
        public virtual Material Material { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        
    }
}
