﻿// <auto-generated />
using System;
using Epets.App.Persistencia.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Epets.App.Persistencia.Migrations
{
    [DbContext(typeof(MfAppContext))]
    [Migration("20210928164139_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nit")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Historia");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColorOjos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorPiel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Estatura")
                        .HasColumnType("real");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoAnimal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.RecomendacionesCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaId");

                    b.ToTable("RecomendacionesCuidado");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.Property<int>("Signo")
                        .HasColumnType("int");

                    b.Property<float>("Valor_signo")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaId");

                    b.ToTable("SignoVital");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SolicitudVisita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("NombreMascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<int>("TipoAnimal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("NombreMascotaId");

                    b.HasIndex("PropietarioId");

                    b.ToTable("SolicitudVisita");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Medico", b =>
                {
                    b.HasBaseType("Epets.App.Dominio.Entidades.Persona");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int");

                    b.HasIndex("EmpresaId");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Propietario", b =>
                {
                    b.HasBaseType("Epets.App.Dominio.Entidades.Persona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Mascota", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Historia", "Historia")
                        .WithMany()
                        .HasForeignKey("HistoriaId");

                    b.HasOne("Epets.App.Dominio.Entidades.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.HasOne("Epets.App.Dominio.Entidades.Propietario", "Propietario")
                        .WithMany("MascotasPropietario")
                        .HasForeignKey("PropietarioId");

                    b.Navigation("Historia");

                    b.Navigation("Medico");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.RecomendacionesCuidado", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Historia", null)
                        .WithMany("Recomendaciones")
                        .HasForeignKey("HistoriaId");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SignoVital", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Historia", null)
                        .WithMany("SignosVitales")
                        .HasForeignKey("HistoriaId");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SolicitudVisita", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("Epets.App.Dominio.Entidades.Mascota", "NombreMascota")
                        .WithMany()
                        .HasForeignKey("NombreMascotaId");

                    b.HasOne("Epets.App.Dominio.Entidades.Propietario", "Propietario")
                        .WithMany("SolicitudVisita")
                        .HasForeignKey("PropietarioId");

                    b.Navigation("Mascota");

                    b.Navigation("NombreMascota");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Medico", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Empresa", null)
                        .WithMany("MedicosVinculados")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Empresa", b =>
                {
                    b.Navigation("MedicosVinculados");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Historia", b =>
                {
                    b.Navigation("Recomendaciones");

                    b.Navigation("SignosVitales");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Propietario", b =>
                {
                    b.Navigation("MascotasPropietario");

                    b.Navigation("SolicitudVisita");
                });
#pragma warning restore 612, 618
        }
    }
}