﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Relationships.Data;

#nullable disable

namespace Relationships.Migrations
{
    [DbContext(typeof(ArtistsContext))]
    [Migration("20220712085149_SupplementDefaultConventionsWithFluentAPI")]
    partial class SupplementDefaultConventionsWithFluentAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Relationships.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Relationships.Studio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<long>("EmpId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmpId")
                        .IsUnique();

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("Relationships.Studio", b =>
                {
                    b.HasOne("Relationships.Employee", "Employee")
                        .WithOne("Studio")
                        .HasForeignKey("Relationships.Studio", "EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Relationships.Employee", b =>
                {
                    b.Navigation("Studio");
                });
#pragma warning restore 612, 618
        }
    }
}
