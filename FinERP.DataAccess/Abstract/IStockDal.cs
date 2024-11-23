using FinERP.Core.DataAccess;
using FinERP.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinERP.DataAccess.Abstract
{
    public interface IStockDal:IEntityRepository<Stock>
    {

    }
}
