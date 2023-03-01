using GestionParking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParking.Data
{
    public class ParkingDbContext: DbContext
    {
        public DbSet<Person> people { get; set; } = null!;
        public DbSet<Customer> customers { get; set; } = null!;
        public DbSet<Director> directors { get; set; } = null!;
        public DbSet<TollCollector> tollCollectors { get; set; } = null!;
        public DbSet<Vehicle> vehicles { get; set; } = null!;
        public DbSet<Truck> trucks { get; set; } = null!;
        public DbSet<Car> cars { get; set; } = null!;
        public DbSet<MotorCycle> motorCycles { get; set; } = null!;
        public DbSet<Floor> floors { get; set; } = null!;
        public DbSet<FirstFloor> firstFloors { get; set; } = null!;
        public DbSet<GroundFloor> groundFloors { get; set; } = null!;
        public DbSet<Basement> basements { get; set; } = null!;
        public DbSet<ParkingTime> parkingTimes { get; set; } = null!;
        public DbSet<Badge> badges { get; set; } = null!;
        public DbSet<WhiteBadge> whiteBadges { get; set; } = null!;
        public DbSet<CustomerBadge> customerBadges { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=parking;uid=root;password=", new MySqlServerVersion(new Version(8, 0, 30)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //descriminator modif
            modelBuilder.Entity<Person>().HasDiscriminator(p => p.Type);
            modelBuilder.Entity<Badge>().HasDiscriminator(b => b.Type);
            modelBuilder.Entity<Floor>().HasDiscriminator(f => f.Type);
            modelBuilder.Entity<Vehicle>().HasDiscriminator(v => v.VehicleType);

            //relation with tables many to one
            modelBuilder.Entity<Badge>()
                .HasMany(b => b.Vehicles)
                .WithOne(v => v.Badge);

            //linking table
            modelBuilder.Entity<ParkingTime>()
                .HasKey(pt => new { pt.VehicleId, pt.FloorId });
            
            //Many to Many relationship the parkingtime table is key to creating the many to many is linking table
            modelBuilder.Entity<ParkingTime>()
                .HasOne(pt => pt.Vehicle)
                .WithMany(v => v.parkingTimes)
                .HasForeignKey(pt => pt.VehicleId);

            modelBuilder.Entity<ParkingTime>()
                .HasOne(pt => pt.Floor)
                .WithMany(f => f.parkingTimes)
                .HasForeignKey(pt => pt.FloorId);

            //one to one
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Badge)
                .WithOne(b => b.Customer)
                .HasForeignKey<Badge>(b => b.CustomerId);
        }
    }
}
