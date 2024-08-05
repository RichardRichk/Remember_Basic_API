﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Contexts;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240805122632_DB")]
    partial class DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Domains.Product", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.HasKey("IdProduct");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
