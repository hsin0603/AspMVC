﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterM.Data;

namespace StarterM.Migrations
{
    [DbContext(typeof(OperaContext))]
    partial class OperaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarterM.Models.Opera", b =>
                {
                    b.Property<int>("OperaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Composer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("OperaID");

                    b.ToTable("Operas");

                    b.HasData(
                        new
                        {
                            OperaID = 1,
                            Composer = "Wolfgang Amadeus Mozart",
                            Title = "Cosi Fan Tutte",
                            Year = 1790
                        },
                        new
                        {
                            OperaID = 2,
                            Composer = "Giuseppe Verdi",
                            Title = "Rigoletto",
                            Year = 1851
                        },
                        new
                        {
                            OperaID = 3,
                            Composer = "John Adams",
                            Title = "Nixon in China",
                            Year = 1987
                        },
                        new
                        {
                            OperaID = 4,
                            Composer = "Alban Berg",
                            Title = "Wozzeck",
                            Year = 1922
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
