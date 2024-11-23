using FinERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinERP.DataAccess.Concrete.EntityFramework.Context
{
    public class FinERPContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-GI9P8D6\\SQLEXPRESS;Database=FinERP;Integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<Stock> Stocks { get; set; } //bunu map leme ile veritabanında ismini değiştirevilirsin
    }
}
