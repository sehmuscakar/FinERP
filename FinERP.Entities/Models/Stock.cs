﻿using FinERP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinERP.Entities.Models
{
    public class Stock : EntityBase
    {
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
    }
}
