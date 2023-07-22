using hometask_17_07.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_17_07.Data
{
    public class GMDBcontext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = localhost;" +
                "Port = 5432;" +
                "User Id = postgres;" +
                "Password = 7788;" +
                "Database = GMBusCarClient;";

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddData(modelBuilder);
        }

        public void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData
                (
                    new Car()
                    {
                        Id = 1,
                        Name = "Malibu 1",
                        Speed = 140
                    },
                    new Car()
                    {
                        Id = 2,
                        Name = "Malibu 2",
                        Speed = 180
                    },
                    new Car()
                    {
                        Id = 3,
                        Name = "Jentra 1.5",
                        Speed = 200
                    }
                );
            modelBuilder.Entity<Bus>().HasData
                (
                     new Bus()
                     {
                         Id = 1,
                         Name = "Mers Bus",
                         Speed = 100
                     },
                     new Bus()
                     {
                         Id = 2,
                         Name = "Electro Bus",
                         Speed = 120
                     },
                     new Bus()
                     {
                         Id = 3,
                         Name = "nimadur Bus",
                         Speed = 160
                     }
                );
            modelBuilder.Entity<Client>().HasData
                (
                    new Client()
                    {
                        Id = 1,
                        Name = "Sarvar"
                    },
                    new Client()
                    {
                        Id = 2,
                        Name = "Ravshan"
                    },
                    new Client()
                    {
                        Id = 3,
                        Name = "Bahriddin"
                    }
                );
        }

    }
}
