using BlazorExplorer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExplorer.Data
{
    public class BlazorExplorerContext : DbContext
    {
        public BlazorExplorerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Table01> Table01s { get; set; }
        public DbSet<Table02> Table02s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table02>().HasKey(x => x.Table01Id);
        }
    }
}
