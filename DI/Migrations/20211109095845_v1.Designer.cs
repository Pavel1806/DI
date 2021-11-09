﻿// <auto-generated />
using DI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211109095845_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("DI.Models.A", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("As");
                });

            modelBuilder.Entity("DI.Models.B", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AId")
                        .IsUnique();

                    b.ToTable("Bs");
                });

            modelBuilder.Entity("DI.Models.C", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BId")
                        .IsUnique();

                    b.ToTable("Cs");
                });

            modelBuilder.Entity("DI.Models.B", b =>
                {
                    b.HasOne("DI.Models.A", "GetA")
                        .WithOne("GetB")
                        .HasForeignKey("DI.Models.B", "AId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GetA");
                });

            modelBuilder.Entity("DI.Models.C", b =>
                {
                    b.HasOne("DI.Models.B", "GetB")
                        .WithOne("GetC")
                        .HasForeignKey("DI.Models.C", "BId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GetB");
                });

            modelBuilder.Entity("DI.Models.A", b =>
                {
                    b.Navigation("GetB");
                });

            modelBuilder.Entity("DI.Models.B", b =>
                {
                    b.Navigation("GetC");
                });
#pragma warning restore 612, 618
        }
    }
}
