﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Persistencia.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220915111833_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto.App.Dominio.Abogado", b =>
                {
                    b.Property<int>("abogadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("anioIngreso")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("numeroTarjetaProfesional")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("abogadoId");

                    b.ToTable("Abogados");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Caso", b =>
                {
                    b.Property<int>("casoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("abogadoId")
                        .HasColumnType("int");

                    b.Property<int>("cantidadTestigos")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("direccionJuzgadoAsignado")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("faseCasoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaInicioCaso")
                        .HasColumnType("datetime2");

                    b.HasKey("casoId");

                    b.HasIndex("abogadoId");

                    b.HasIndex("clienteId");

                    b.HasIndex("faseCasoId");

                    b.ToTable("Casos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("clienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("edad")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("genero")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("clienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.FaseCaso", b =>
                {
                    b.Property<int>("faseCasoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreFase")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("faseCasoId");

                    b.ToTable("FaseCasos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Caso", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Abogado", "abogado")
                        .WithMany("casos")
                        .HasForeignKey("abogadoId");

                    b.HasOne("Proyecto.App.Dominio.Cliente", "cliente")
                        .WithMany("casos")
                        .HasForeignKey("clienteId");

                    b.HasOne("Proyecto.App.Dominio.FaseCaso", "faseCaso")
                        .WithMany("casos")
                        .HasForeignKey("faseCasoId");

                    b.Navigation("abogado");

                    b.Navigation("cliente");

                    b.Navigation("faseCaso");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Abogado", b =>
                {
                    b.Navigation("casos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Cliente", b =>
                {
                    b.Navigation("casos");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.FaseCaso", b =>
                {
                    b.Navigation("casos");
                });
#pragma warning restore 612, 618
        }
    }
}
