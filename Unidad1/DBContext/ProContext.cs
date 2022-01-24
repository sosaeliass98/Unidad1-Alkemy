using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad1.Entidades;

namespace Unidad1.DBContext
{
    internal class ProContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configurar Connection String dentro del optionsBuilder
            optionsBuilder.UseSqlServer(@"Data Source =.; Initial Catalog = Proyecto; Integrated Security = True");
        }
    }
}
