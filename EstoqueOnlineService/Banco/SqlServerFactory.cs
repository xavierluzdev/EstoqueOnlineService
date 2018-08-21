using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace EstoqueOnlineService.Banco
{
    public class SqlServerFactory
    {
        private SqlConnection connection = null;
        private const string CONNECTIONSTRING = @"Data Source=D-PROD-BP100906\SQLEXPRESS;Initial Catalog=EstoqueOnline;persist security info=True;User ID=sa;Password=@Prodesp2018;MultipleActiveResultSets=True;App=EntityFramework";

        private SqlServerFactory()
        {
            connection = new SqlConnection(CONNECTIONSTRING);

        }
        public static SqlServerFactory Create()
        {
            return new SqlServerFactory();
        }
        public DbConnection getConnection()
        {
            return this.connection;
        }
    }
}
