using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Sincro.Context
{
    public class SincroDBContext : DbContext
    {
        public SincroDBContext(DbContextOptions<SincroDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relation>()
                .HasKey(r => new { r.IdUser, r.IdTable });

            modelBuilder.Entity<Relation>()
                .HasOne(r => r.User)
                .WithMany( r => r.Relations)
                .HasForeignKey(r => r.IdUser);

            modelBuilder.Entity<Relation>()
                .HasOne(r => r.Table)
                .WithMany(r => r.Relations)
                .HasForeignKey(r => r.IdTable);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }        
        public DbSet<Table> Tables { get; set; }
        public DbSet<Relation> Relations { get; set; }


    }

}

