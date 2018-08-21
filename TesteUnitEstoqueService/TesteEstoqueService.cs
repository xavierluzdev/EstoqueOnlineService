using EstoqueOnlineService.Material;
using EstoqueOnlineService.Material.Contexto;
using EstoqueOnlineService.Material.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteUnitEstoqueService
{
    [TestClass]
    public class TesteEstoqueService
    {
        [TestMethod]
        public void CreateCategoria()
        {
            var factory = MaterialFactory.Create();

            Categoria categoria = factory.getCategoria();
            categoria.Descricao = "Componente para ser usado em computador";
            categoria.Nome = "Teclado";
            categoria.Status = "AT";

           
            MaterialContexto materialContexto = factory.getContexto();

            materialContexto.Categoria.Add(categoria);
            int retorno = materialContexto.SaveChanges();
            Assert.AreEqual(retorno, 1);
        }
    }
}
