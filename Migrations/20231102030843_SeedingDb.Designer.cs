﻿// <auto-generated />
using System;
using CaminhadasAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CaminhadasAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231102030843_SeedingDb")]
    partial class SeedingDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CaminhadasAPI.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1fe38b76-cc9c-47ce-9b18-bb08b77335bf"),
                            Name = "Very Easy"
                        },
                        new
                        {
                            Id = new Guid("7fbd596b-1522-4c31-aac2-e1759654903f"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("249ab280-e815-44ed-8593-b87f30b3fcca"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("2facf73b-413a-4f41-8fb1-9c0db21e15cd"),
                            Name = "Hard"
                        },
                        new
                        {
                            Id = new Guid("8c880814-0a32-47f6-a372-f298b830b405"),
                            Name = "Very Hard"
                        });
                });

            modelBuilder.Entity("CaminhadasAPI.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegionImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3022ea41-1cac-4ba5-9630-405e89742e5a"),
                            Code = "SP",
                            Name = "São Paulo",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/11/Parque_do_ibirapuera_visto_do_c%C3%A9u.jpg"
                        },
                        new
                        {
                            Id = new Guid("a0e7c59e-408f-4a00-a947-7210b6c0e963"),
                            Code = "MG",
                            Name = "Minas Gerais",
                            RegionImageUrl = "https://blog.entretrilhas.com.br/wp-content/uploads/2022/02/trekking_02-1024x576.jpg"
                        },
                        new
                        {
                            Id = new Guid("56a3a88e-b943-4fb0-9959-c74c183101c8"),
                            Code = "MG",
                            Name = "Mato Grosso",
                            RegionImageUrl = "https://blog.entretrilhas.com.br/wp-content/uploads/2022/02/trekking_02-1024x576.jpg"
                        });
                });

            modelBuilder.Entity("CaminhadasAPI.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descrition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uuid");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uuid");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("CaminhadasAPI.Models.Domain.Walk", b =>
                {
                    b.HasOne("CaminhadasAPI.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaminhadasAPI.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
