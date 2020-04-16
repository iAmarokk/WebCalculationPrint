using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCalculationPrint.Models;

namespace WebCalculationPrint.Data
{
    public class WebCalculationPrintContext : DbContext
    {
        public WebCalculationPrintContext (DbContextOptions<WebCalculationPrintContext> options)
            : base(options)
        {
        }

        public DbSet<Calculation> Calculations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Colourfulness> Colourfulnesses { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Paper> Papers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculation>().ToTable("Calculation");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Colourfulness>().ToTable("Colourfulness");
            modelBuilder.Entity<Format>().ToTable("Format");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Paper>().ToTable("Paper");
        }
    }
}
