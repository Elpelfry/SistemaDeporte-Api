﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeporteApi.DAL;

#nullable disable

namespace SistemaDeporteApi.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.Ajustes", b =>
                {
                    b.Property<int>("AjusteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AjusteId"));

                    b.Property<string>("PartidoActual")
                        .HasColumnType("longtext");

                    b.Property<float>("PorcentajeBueno")
                        .HasColumnType("float");

                    b.Property<float>("PorcentajeExcelente")
                        .HasColumnType("float");

                    b.Property<float>("PorcentajeMuyBueno")
                        .HasColumnType("float");

                    b.Property<float>("PorcentajeRegular")
                        .HasColumnType("float");

                    b.HasKey("AjusteId");

                    b.ToTable("Ajustes");
                });

            modelBuilder.Entity("Shared.Models.Equipos", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EquipoId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("EquipoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Shared.Models.EstadisticaEquipos", b =>
                {
                    b.Property<int>("EstadisticaEquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EstadisticaEquipoId"));

                    b.Property<int>("AR")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("GP")
                        .HasColumnType("int");

                    b.Property<int>("HR")
                        .HasColumnType("int");

                    b.Property<int>("L")
                        .HasColumnType("int");

                    b.Property<float>("PAPG")
                        .HasColumnType("float");

                    b.Property<int>("PC")
                        .HasColumnType("int");

                    b.Property<float>("PD")
                        .HasColumnType("float");

                    b.Property<float>("PPG")
                        .HasColumnType("float");

                    b.Property<int>("R")
                        .HasColumnType("int");

                    b.Property<int>("W")
                        .HasColumnType("int");

                    b.Property<float>("WP")
                        .HasColumnType("float");

                    b.HasKey("EstadisticaEquipoId");

                    b.ToTable("EstadisticaEquipos");
                });

            modelBuilder.Entity("Shared.Models.EstadisticaJugadores", b =>
                {
                    b.Property<int>("EstadisticaJugadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EstadisticaJugadorId"));

                    b.Property<float>("APG")
                        .HasColumnType("float");

                    b.Property<float>("BPG")
                        .HasColumnType("float");

                    b.Property<float>("FG")
                        .HasColumnType("float");

                    b.Property<float>("FT")
                        .HasColumnType("float");

                    b.Property<int>("JugadorId")
                        .HasColumnType("int");

                    b.Property<float>("MPG")
                        .HasColumnType("float");

                    b.Property<float>("PPG")
                        .HasColumnType("float");

                    b.Property<float>("RPG")
                        .HasColumnType("float");

                    b.Property<float>("SPG")
                        .HasColumnType("float");

                    b.Property<float>("TO")
                        .HasColumnType("float");

                    b.Property<float>("TRESP")
                        .HasColumnType("float");

                    b.HasKey("EstadisticaJugadorId");

                    b.ToTable("EstadisticaJugadores");
                });

            modelBuilder.Entity("Shared.Models.Jugadores", b =>
                {
                    b.Property<int>("JugadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("JugadorId"));

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.HasKey("JugadorId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("Shared.Models.Partidos", b =>
                {
                    b.Property<int>("PartidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PartidoId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("PartidoId");

                    b.ToTable("Partidos");
                });
#pragma warning restore 612, 618
        }
    }
}
