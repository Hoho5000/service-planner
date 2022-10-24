﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicePlanner.Data;

#nullable disable

namespace ServicePlanner.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Institution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("ServicePlanner.Data.Service.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ServicePlanner.Data.Service.ServiceItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ServiceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceItem");
                });

            modelBuilder.Entity("ServicePlanner.Data.Music.Song", b =>
                {
                    b.HasBaseType("ServicePlanner.Data.Service.ServiceItem");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Songs", (string)null);
                });

            modelBuilder.Entity("ServicePlanner.Data.Service.GeneralServiceItem", b =>
                {
                    b.HasBaseType("ServicePlanner.Data.Service.ServiceItem");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("GeneralServiceItems", (string)null);
                });

            modelBuilder.Entity("Institution", b =>
                {
                    b.HasOne("Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("ServicePlanner.Data.Service.ServiceItem", b =>
                {
                    b.HasOne("ServicePlanner.Data.Service.Service", null)
                        .WithMany("Items")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("ServicePlanner.Data.Music.Song", b =>
                {
                    b.HasOne("ServicePlanner.Data.Service.ServiceItem", null)
                        .WithOne()
                        .HasForeignKey("ServicePlanner.Data.Music.Song", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServicePlanner.Data.Service.GeneralServiceItem", b =>
                {
                    b.HasOne("ServicePlanner.Data.Service.ServiceItem", null)
                        .WithOne()
                        .HasForeignKey("ServicePlanner.Data.Service.GeneralServiceItem", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServicePlanner.Data.Service.Service", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
