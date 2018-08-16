using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Material.Entidades
{
    public class Classificacao
    {
        protected Classificacao()
        {
            this.Materiais = new List<Material>();
        }
        internal static Classificacao Create()
        {
            return new Classificacao();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        //Navegação
        public virtual ICollection<Material> Materiais { get; set; }
    }
}
