using EstoqueOnlineService.Material.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueOnlineService.Banco
{
    public class MigrationContexto : IDesignTimeDbContextFactory<MaterialContexto>
    {
        public MaterialContexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MaterialContexto>();
            optionsBuilder.UseSqlServer(SqlServerFactory.Create().getConnection());

            return MaterialContexto.Create(optionsBuilder.Options);
        }
    }
}
