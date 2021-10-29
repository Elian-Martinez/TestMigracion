using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Migracion_.Models
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Person DbSet
            modelBuilder.Entity<Person>().Property(x => x.PersonId).HasColumnName("Id").IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonName).HasColumnName("Name").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonLastName).HasColumnName("LastName").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonOfBirth).HasColumnName("BirthdayDate").IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonPassport).HasColumnName("Passport").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonAdress).HasColumnName("Adress").HasMaxLength(35).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonGender).HasColumnName("Gender").HasMaxLength(9).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PersonPhoto).HasColumnName("Photo").IsRequired();

            //Requests DbSet
            modelBuilder.Entity<Requests>().Property(x => x.RequestsId).HasColumnName("Id").IsRequired();
            modelBuilder.Entity<Requests>().Property(x => x.RequestsName).HasColumnName("Description").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Requests>().Property(x => x.RequestsEstate).HasColumnName("Estate").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Requests>().Property(x => x.RequestsCreation).HasColumnName("Creation").IsRequired();

            //Equipment DbSet
            modelBuilder.Entity<Equipment>().Property(x => x.EquipmentId).HasColumnName("Id").IsRequired();
            modelBuilder.Entity<Equipment>().Property(x => x.PersonId).IsRequired();
            modelBuilder.Entity<Equipment>().Property(x => x.RequestsId).IsRequired();
            modelBuilder.Entity<Equipment>().Property(x => x.CreationDate).HasColumnName("CreationDate").IsRequired();
        }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
