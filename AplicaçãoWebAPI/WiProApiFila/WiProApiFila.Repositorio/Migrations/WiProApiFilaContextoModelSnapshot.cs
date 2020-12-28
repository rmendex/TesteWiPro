﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WiProApiFila.Repositorio.Contexto;

namespace WiProApiFila.Repositorio.Migrations
{
    [DbContext(typeof(WiProApiFilaContexto))]
    partial class WiProApiFilaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WiProApiFila.Dominio.Entidades.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtFim");

                    b.Property<DateTime>("DtInicio");

                    b.Property<string>("Moeda");

                    b.HasKey("ID");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
