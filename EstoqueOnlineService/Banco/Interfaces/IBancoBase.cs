using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace EstoqueOnlineService.Banco.Interfaces
{
    public interface IBancoBase
    {
        DbConnection getConnection();
    }
}
