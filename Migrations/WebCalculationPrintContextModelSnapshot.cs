﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCalculationPrint.Data;

namespace WebCalculationPrint.Migrations
{
    [DbContext(typeof(WebCalculationPrintContext))]
    partial class WebCalculationPrintContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebCalculationPrint.Models.Calculation", b =>
                {
                    b.Property<int>("CalculationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColourfulnessID")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("FormatID")
                        .HasColumnType("int");

                    b.Property<int>("PaperID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("TotalPages")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("CalculationID");

                    b.HasIndex("ColourfulnessID");

                    b.HasIndex("FormatID");

                    b.HasIndex("PaperID");

                    b.ToTable("Calculation");
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Colourfulness", b =>
                {
                    b.Property<int>("ColourfulnessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ColourfulnessRate")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColourfulnessID");

                    b.ToTable("Colourfulness");
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Format", b =>
                {
                    b.Property<int>("FormatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("FormatRate")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormatID");

                    b.ToTable("Format");
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CalculationID")
                        .HasColumnType("int");

                    b.Property<int>("CalculationsID")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CalculationID");

                    b.HasIndex("ClientID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Paper", b =>
                {
                    b.Property<int>("PaperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("PaperCost")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Thickness")
                        .HasColumnType("int");

                    b.HasKey("PaperID");

                    b.ToTable("Paper");
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Calculation", b =>
                {
                    b.HasOne("WebCalculationPrint.Models.Colourfulness", "Colourfulness")
                        .WithMany()
                        .HasForeignKey("ColourfulnessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebCalculationPrint.Models.Format", "Format")
                        .WithMany()
                        .HasForeignKey("FormatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebCalculationPrint.Models.Paper", "Paper")
                        .WithMany()
                        .HasForeignKey("PaperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebCalculationPrint.Models.Order", b =>
                {
                    b.HasOne("WebCalculationPrint.Models.Calculation", "Calculation")
                        .WithMany()
                        .HasForeignKey("CalculationID");

                    b.HasOne("WebCalculationPrint.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
