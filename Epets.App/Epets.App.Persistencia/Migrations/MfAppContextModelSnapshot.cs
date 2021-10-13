﻿// <auto-generated />
using System;
using Epets.App.Persistencia.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Epets.App.Persistencia.Migrations
{
    [DbContext(typeof(MfAppContext))]
    partial class MfAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Empresa", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Direccion");

                    b.Property<int?>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("Nit")
                        .HasColumnType("int")
                        .HasColumnName("Nit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("IdEmpresa");

                    b.HasIndex("IdMedico");

                    b.ToTable("EmpresaDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Historia", b =>
                {
                    b.Property<int>("IdHistoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaVisita")
                        .HasMaxLength(12)
                        .HasColumnType("datetime2")
                        .HasColumnName("DateTime");

                    b.Property<int?>("IdRecomendacion")
                        .HasColumnType("int");

                    b.Property<int?>("IdSigno")
                        .HasColumnType("int");

                    b.Property<string>("Medicamento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Medicamento");

                    b.Property<string>("Recomendaciones")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Recomendaciones");

                    b.HasKey("IdHistoria");

                    b.HasIndex("IdRecomendacion");

                    b.HasIndex("IdSigno");

                    b.ToTable("Historia");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("ColorOjos")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ColorOjos");

                    b.Property<string>("ColorPiel")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ColorPiel");

                    b.Property<float>("Estatura")
                        .HasColumnType("real")
                        .HasColumnName("Estatura");

                    b.Property<int?>("IdHistoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int?>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("NombreMascota")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NombreMascota");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Raza");

                    b.Property<string>("TipoMascota")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("TipoMascota");

                    b.HasKey("IdMascota");

                    b.HasIndex("IdHistoria");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdPropietario");

                    b.ToTable("MascotaDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Cedula");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.ToTable("PersonaDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.RecomendacionesCuidado", b =>
                {
                    b.Property<int>("IdRecomendacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Sugerencias");

                    b.Property<DateTime>("FechaHora")
                        .HasMaxLength(12)
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha");

                    b.HasKey("IdRecomendacion");

                    b.ToTable("RecomendacionesDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SignoVital", b =>
                {
                    b.Property<int>("IdSigno")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<DateTime>("FechaHora")
                        .HasMaxLength(12)
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.HasKey("IdSigno");

                    b.HasIndex("IdAnimal");

                    b.ToTable("SignoVitalDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SolicitudVisita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaVisita");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<int?>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int?>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("NombreMascota")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NombreMascota");

                    b.HasKey("Id");

                    b.HasIndex("IdAnimal");

                    b.HasIndex("IdMascota");

                    b.HasIndex("IdPropietario");

                    b.ToTable("SolicitudVisitaDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.TipoSigno", b =>
                {
                    b.Property<int>("IdSigno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoAnimo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("EstadoAnimo");

                    b.Property<int>("Frecuencia_Respiratoria")
                        .HasColumnType("int")
                        .HasColumnName("FrecuenciaRespiratoria");

                    b.Property<int>("Freuencia_Cardiaca")
                        .HasColumnType("int")
                        .HasColumnName("FrecuenciaCardiaca");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("Peso");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int")
                        .HasColumnName("Temperatura");

                    b.HasKey("IdSigno");

                    b.ToTable("TipoSignoDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.TipoAnimal", b =>
                {
                    b.Property<int>("IdAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("IdAnimal");

                    b.ToTable("TipoAnimalDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Medico", b =>
                {
                    b.HasBaseType("Epets.App.Dominio.Entidades.Persona");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int")
                        .HasColumnName("IdMedico");

                    b.Property<int>("TarjetaProfesional")
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasColumnName("TarjetaProfesional");

                    b.HasIndex("IdAnimal");

                    b.ToTable("MedicoDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Propietario", b =>
                {
                    b.HasBaseType("Epets.App.Dominio.Entidades.Persona");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Direccion");

                    b.Property<int?>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int")
                        .HasColumnName("IdPropietario");

                    b.Property<int?>("IdSolicitud")
                        .HasColumnType("int");

                    b.HasIndex("IdMascota");

                    b.HasIndex("IdSolicitud");

                    b.ToTable("PropietariosDb");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Empresa", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Historia", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.RecomendacionesCuidado", "RecomendacionesCuidado")
                        .WithMany()
                        .HasForeignKey("IdRecomendacion");

                    b.HasOne("Epets.App.Dominio.Entidades.SignoVital", "SignoVital")
                        .WithMany()
                        .HasForeignKey("IdSigno");

                    b.Navigation("RecomendacionesCuidado");

                    b.Navigation("SignoVital");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Mascota", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Historia", "Historia")
                        .WithMany()
                        .HasForeignKey("IdHistoria");

                    b.HasOne("Epets.App.Dominio.Entidades.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico");

                    b.HasOne("Epets.App.Dominio.Entidades.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("IdPropietario");

                    b.Navigation("Historia");

                    b.Navigation("Medico");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SignoVital", b =>
                {
                    b.HasOne("Epets.App.Dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.HasOne("Epets.App.Dominio.Entidades.TipoSigno", "TipoSigno")
                        .WithMany()
                        .HasForeignKey("IdSigno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoAnimal");

                    b.Navigation("TipoSigno");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.SolicitudVisita", b =>
                {
                    b.HasOne("Epets.App.Dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.HasOne("Epets.App.Dominio.Entidades.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("IdMascota");

                    b.HasOne("Epets.App.Dominio.Entidades.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("IdPropietario");

                    b.Navigation("Mascota");

                    b.Navigation("Propietario");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Medico", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Persona", null)
                        .WithOne()
                        .HasForeignKey("Epets.App.Dominio.Entidades.Medico", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Epets.App.Dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("Epets.App.Dominio.Entidades.Propietario", b =>
                {
                    b.HasOne("Epets.App.Dominio.Entidades.Persona", null)
                        .WithOne()
                        .HasForeignKey("Epets.App.Dominio.Entidades.Propietario", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Epets.App.Dominio.Entidades.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("IdMascota");

                    b.HasOne("Epets.App.Dominio.Entidades.SolicitudVisita", "SolicitudVisita")
                        .WithMany()
                        .HasForeignKey("IdSolicitud");

                    b.Navigation("Mascota");

                    b.Navigation("SolicitudVisita");
                });
#pragma warning restore 612, 618
        }
    }
}
