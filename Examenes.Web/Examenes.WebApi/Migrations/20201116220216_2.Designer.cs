﻿// <auto-generated />
using System;
using Examenes.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examenes.WebApi.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20201116220216_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Examenes.WebApi.Data.Entities.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carrera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Examenes.WebApi.Data.Entities.Examen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<string>("Pregunta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Respuesta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.ToTable("Examenes");
                });

            modelBuilder.Entity("Examenes.WebApi.Data.Entities.Examen", b =>
                {
                    b.HasOne("Examenes.WebApi.Data.Entities.Alumno", "Alumno")
                        .WithMany("Examenes")
                        .HasForeignKey("AlumnoId");

                    b.Navigation("Alumno");
                });

            modelBuilder.Entity("Examenes.WebApi.Data.Entities.Alumno", b =>
                {
                    b.Navigation("Examenes");
                });
#pragma warning restore 612, 618
        }
    }
}
