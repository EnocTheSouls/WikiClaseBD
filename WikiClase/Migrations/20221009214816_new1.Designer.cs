﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WikiClase.Data;

#nullable disable

namespace WikiClase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221009214816_new1")]
    partial class new1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WikiClase.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WikiClase.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.Property<int>("categoriaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("categoriaId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("WikiClase.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<int>("categoriaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("categoriaId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("WikiClase.Models.Post", b =>
                {
                    b.HasOne("WikiClase.Models.Categoria", "categoria")
                        .WithMany("Posts")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("WikiClase.Models.Tag", b =>
                {
                    b.HasOne("WikiClase.Models.Categoria", "Categorias")
                        .WithMany("tag")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("WikiClase.Models.Categoria", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("tag");
                });
#pragma warning restore 612, 618
        }
    }
}