﻿// <auto-generated />
using System;
using Gmlu.Demo.EntityFramework.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gmlu.Demo.EntityFramework.Migrations
{
    [DbContext(typeof(StatsContext))]
    partial class StatsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gmlu.Demo.EntityFramework.Models.MeasurePoint", b =>
                {
                    b.Property<Guid>("MeasurePointId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Humidity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("RaspberryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Temp")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MeasurePointId");

                    b.HasIndex("RaspberryId");

                    b.ToTable("MeasurePoint");
                });

            modelBuilder.Entity("Gmlu.Demo.EntityFramework.Models.Raspberry", b =>
                {
                    b.Property<Guid>("RaspberryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IPadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(130)")
                        .HasMaxLength(130);

                    b.Property<int>("TestProperty")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(130)")
                        .HasMaxLength(130);

                    b.HasKey("RaspberryId");

                    b.ToTable("Raspberry");
                });

            modelBuilder.Entity("Gmlu.Demo.EntityFramework.Models.MeasurePoint", b =>
                {
                    b.HasOne("Gmlu.Demo.EntityFramework.Models.Raspberry", "Raspberry")
                        .WithMany()
                        .HasForeignKey("RaspberryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
