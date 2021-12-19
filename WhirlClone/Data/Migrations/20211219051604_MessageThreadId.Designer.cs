﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhirlClone.Data;

namespace WhirlClone.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211219051604_MessageThreadId")]
    partial class MessageThreadId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("WhirlClone.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<int>("ThreadId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WhirlClone.Models.Thread", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Threads");
                });
#pragma warning restore 612, 618
        }
    }
}