﻿// <auto-generated />
using System;
using Flayer5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flayer5.Migrations
{
    [DbContext(typeof(Flayer5Context))]
    [Migration("20220216141319_BiletPachet")]
    partial class BiletPachet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Flayer5.Models.Bilet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destinatie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.HasIndex("CompanieID");

                    b.ToTable("Bilet");
                });

            modelBuilder.Entity("Flayer5.Models.BiletPachet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BiletID")
                        .HasColumnType("int");

                    b.Property<int>("PachetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BiletID");

                    b.HasIndex("PachetID");

                    b.ToTable("BiletPachet");
                });

            modelBuilder.Entity("Flayer5.Models.Companie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume_Companie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Companie");
                });

            modelBuilder.Entity("Flayer5.Models.Pachet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume_Pachet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pachet");
                });

            modelBuilder.Entity("Flayer5.Models.Bilet", b =>
                {
                    b.HasOne("Flayer5.Models.Companie", "Companie")
                        .WithMany("Bilete")
                        .HasForeignKey("CompanieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companie");
                });

            modelBuilder.Entity("Flayer5.Models.BiletPachet", b =>
                {
                    b.HasOne("Flayer5.Models.Bilet", "Bilet")
                        .WithMany("BiletPachete")
                        .HasForeignKey("BiletID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Flayer5.Models.Pachet", "Pachet")
                        .WithMany("BiletPachete")
                        .HasForeignKey("PachetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bilet");

                    b.Navigation("Pachet");
                });

            modelBuilder.Entity("Flayer5.Models.Bilet", b =>
                {
                    b.Navigation("BiletPachete");
                });

            modelBuilder.Entity("Flayer5.Models.Companie", b =>
                {
                    b.Navigation("Bilete");
                });

            modelBuilder.Entity("Flayer5.Models.Pachet", b =>
                {
                    b.Navigation("BiletPachete");
                });
#pragma warning restore 612, 618
        }
    }
}