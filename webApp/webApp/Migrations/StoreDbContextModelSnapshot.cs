﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webApp.Models;

namespace webApp.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("webApp.Models.Fattura", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("dataFattura")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("dataPagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("dataRicezione")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float?>("importo")
                        .HasColumnType("real");

                    b.Property<string>("intestatario")
                        .HasColumnType("text");

                    b.Property<string>("metodoPagamento")
                        .HasColumnType("text");

                    b.Property<string>("numeroFattura")
                        .HasColumnType("text");

                    b.Property<string>("pagatore")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Fattura");
                });
#pragma warning restore 612, 618
        }
    }
}
