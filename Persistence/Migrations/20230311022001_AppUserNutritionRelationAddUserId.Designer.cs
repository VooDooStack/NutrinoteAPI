﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230311022001_AppUserNutritionRelationAddUserId")]
    partial class AppUserNutritionRelationAddUserId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Domain.Nutrition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AppUserId")
                        .HasColumnType("text");

                    b.Property<double>("CalciumIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("CarbohydrateIntake")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("FatIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("FiberIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("IronIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("ProteinIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("SodiumIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("SugarIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("VitaminAIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("VitaminCIntake")
                        .HasColumnType("double precision");

                    b.Property<double>("WaterIntake")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Barcode")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Nutrition", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany("Nutrition")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Navigation("Nutrition");
                });
#pragma warning restore 612, 618
        }
    }
}
