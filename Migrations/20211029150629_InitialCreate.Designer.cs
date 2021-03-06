// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Migracion_.Models;

namespace Test_Migracion_.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20211029150629_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_Migracion_.Models.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationDate");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("RequestsId")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.HasIndex("RequestsId")
                        .IsUnique();

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("Test_Migracion_.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonAdress")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasColumnName("Adress");

                    b.Property<string>("PersonGender")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("Gender");

                    b.Property<string>("PersonLastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("LastName");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("PersonOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthdayDate");

                    b.Property<int>("PersonPassport")
                        .HasMaxLength(11)
                        .HasColumnType("int")
                        .HasColumnName("Passport");

                    b.Property<byte[]>("PersonPhoto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("Photo");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Test_Migracion_.Models.Requests", b =>
                {
                    b.Property<int>("RequestsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestsCreation")
                        .HasColumnType("datetime2")
                        .HasColumnName("Creation");

                    b.Property<string>("RequestsEstate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Estate");

                    b.Property<string>("RequestsName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)")
                        .HasColumnName("Description");

                    b.HasKey("RequestsId");

                    b.HasIndex("PersonId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Test_Migracion_.Models.Equipment", b =>
                {
                    b.HasOne("Test_Migracion_.Models.Person", "Person")
                        .WithOne("Equipment")
                        .HasForeignKey("Test_Migracion_.Models.Equipment", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Migracion_.Models.Requests", "Requests")
                        .WithOne("Equipment")
                        .HasForeignKey("Test_Migracion_.Models.Equipment", "RequestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Test_Migracion_.Models.Requests", b =>
                {
                    b.HasOne("Test_Migracion_.Models.Person", "Person")
                        .WithMany("Requests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Test_Migracion_.Models.Person", b =>
                {
                    b.Navigation("Equipment");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Test_Migracion_.Models.Requests", b =>
                {
                    b.Navigation("Equipment");
                });
#pragma warning restore 612, 618
        }
    }
}
