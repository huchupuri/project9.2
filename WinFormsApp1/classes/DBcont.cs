using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// класс с подключением к бд
        /// </summary>
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=ep-silent-dawn-ab7uegdz-pooler.eu-west-2.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_g6M8QBZaoCJU;SSL Mode=Require";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Event>().ToTable("events", "public");
        }
    }
}
