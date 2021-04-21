using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<Evento> Evento { get; set; }
        public DbSet<Evento> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     
            modelBuilder.Entity<Evento>()
                .Property(c => c.Descricao)
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            base.OnModelCreating(modelBuilder);
        }

    }
}
