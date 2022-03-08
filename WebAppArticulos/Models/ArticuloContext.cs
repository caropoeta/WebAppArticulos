using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebAppArticulos.Models
{
    public class ArticuloContext : DbContext
    {
        public ArticuloContext (DbContextOptions<ArticuloContext> options)
            :base(options)
        {

        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Producto>().ToTable("Producto");
        }
    }
}
