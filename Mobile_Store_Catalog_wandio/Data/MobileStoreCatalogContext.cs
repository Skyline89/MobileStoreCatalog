using Microsoft.EntityFrameworkCore;
using Mobile_Store_Catalog_wandio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Data
{
    public class MobileStoreCatalogContext : DbContext
    {
        public MobileStoreCatalogContext()
        {
        }
        public MobileStoreCatalogContext(DbContextOptions<MobileStoreCatalogContext> options)
            : base(options)
        {
        }
        public DbSet<Manufactor> Manufactors { get; set; }
        public DbSet<OperationSystem> OperationSystems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}
