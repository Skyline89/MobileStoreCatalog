using System;
using Microsoft.EntityFrameworkCore;

namespace Mobile_Store_Catalog_wandio.Models
{
    public partial class MobileStoreCatalogContext : DbContext
    {
        public MobileStoreCatalogContext(DbContextOptions<MobileStoreCatalogContext>options)
            : base(options)
        {
        }
        public DbSet<Manufactor> Manufactors { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}