﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tar_5.Data;

#nullable disable

namespace Tar_5.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241018021831_Primera")]
    partial class Primera
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Tar_5.Models.Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ArmaFavorita")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HabilidadEspecial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenPersonaje")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NivelPoder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("RolEnJuego")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("VideojuegoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VideojuegoId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("Tar_5.Models.Plataforma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Plataformas");
                });

            modelBuilder.Entity("Tar_5.Models.Videojuego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desarrollador")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenPortada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("PlataformaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlataformaId");

                    b.ToTable("Videojuegos");
                });

            modelBuilder.Entity("Tar_5.Models.Personaje", b =>
                {
                    b.HasOne("Tar_5.Models.Videojuego", "Videojuego")
                        .WithMany("Personajes")
                        .HasForeignKey("VideojuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Videojuego");
                });

            modelBuilder.Entity("Tar_5.Models.Videojuego", b =>
                {
                    b.HasOne("Tar_5.Models.Plataforma", "Plataforma")
                        .WithMany("Videojuegos")
                        .HasForeignKey("PlataformaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plataforma");
                });

            modelBuilder.Entity("Tar_5.Models.Plataforma", b =>
                {
                    b.Navigation("Videojuegos");
                });

            modelBuilder.Entity("Tar_5.Models.Videojuego", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}