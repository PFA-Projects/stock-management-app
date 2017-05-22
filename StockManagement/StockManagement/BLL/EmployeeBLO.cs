﻿// Mariam Ait Al

using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.BLL
{
    /// <summary>
    /// en : Personnes Management
    /// fr : Gestion des personnes
    /// </summary>
    public class EmployeeBLO:BaseBLO<Employee>
    {
        ModelContext db = new ModelContext();

        public EmployeeBLO(DbContext context) : base(context)
        {
        }

        public EmployeeBLO() : base()
        {
        }
    }
}
