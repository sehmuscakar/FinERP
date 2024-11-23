using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinERP.Core.Entities
{
    public class EntityBase:IEntity
    {
        public Guid Id { get; set; }// = new Guid();
    }
}
