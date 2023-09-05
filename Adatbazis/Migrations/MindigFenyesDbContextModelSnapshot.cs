﻿// <auto-generated />
using System;
using Adatbazis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Adatbazis.Migrations
{
    [DbContext(typeof(MindigFenyesDbContext))]
    partial class MindigFenyesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Adatbazis.Models.Bejelentes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BejelentesDatuma")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("DolgozoId")
                        .HasColumnType("int");

                    b.Property<string>("Iranyitoszam")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime?>("JavitasDatuma")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JavitasTipusId")
                        .HasColumnType("int");

                    b.Property<string>("Varos")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("DolgozoId");

                    b.HasIndex("JavitasTipusId");

                    b.ToTable("Bejelentesek");
                });

            modelBuilder.Entity("Adatbazis.Models.Dolgozo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KeresztNev")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VezetekNev")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Dolgozok");
                });

            modelBuilder.Entity("Adatbazis.Models.JavitasTipus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TipusNev")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("JavitasTipusok");
                });

            modelBuilder.Entity("Adatbazis.Models.Bejelentes", b =>
                {
                    b.HasOne("Adatbazis.Models.Dolgozo", "Dolgozo")
                        .WithMany()
                        .HasForeignKey("DolgozoId");

                    b.HasOne("Adatbazis.Models.JavitasTipus", "JavitasTipus")
                        .WithMany()
                        .HasForeignKey("JavitasTipusId");

                    b.Navigation("Dolgozo");

                    b.Navigation("JavitasTipus");
                });
#pragma warning restore 612, 618
        }
    }
}
