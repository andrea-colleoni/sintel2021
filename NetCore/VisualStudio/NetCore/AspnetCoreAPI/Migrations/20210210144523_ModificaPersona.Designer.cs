﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreCL;

namespace AspnetCoreAPI.Migrations
{
    [DbContext(typeof(CorsoContext))]
    [Migration("20210210144523_ModificaPersona")]
    partial class ModificaPersona
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetStdCL.Model.Persona", b =>
                {
                    b.Property<string>("CodiceFiscale")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indirizzo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodiceFiscale");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}
