﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pubBASS.Models;

namespace pubBASS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200922124614_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pubBASS.Models.Pub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Municipality = "Liberec",
                            Name = "Svah"
                        },
                        new
                        {
                            Id = 2,
                            Municipality = "Jablonec nad Nisou",
                            Name = "Techtle"
                        },
                        new
                        {
                            Id = 3,
                            Municipality = "The Other End Of Universe",
                            Name = "Pub At The Other End Of Universe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
