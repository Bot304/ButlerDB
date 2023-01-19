using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ButlerDataBase.Models
{
    class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Explication> Explications { get; set; }
        public virtual DbSet<Lighting> Lightings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=C:\\\\C:\\Users\\EGOR\\Butlerdb.mdf");
        }
        
    }
    
}
