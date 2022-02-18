﻿// <auto-generated />
using EFCoreCodeFirstSample.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreCodeFirstSample.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220215215449_turler")]
    partial class turler
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Entities.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasimYili")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("int");

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YazarId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Entities.Tur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turler");
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Entities.Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("KitapTur", b =>
                {
                    b.Property<int>("KitaplarId")
                        .HasColumnType("int");

                    b.Property<int>("TurlerId")
                        .HasColumnType("int");

                    b.HasKey("KitaplarId", "TurlerId");

                    b.HasIndex("TurlerId");

                    b.ToTable("KitapTur");
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Entities.Kitap", b =>
                {
                    b.HasOne("EFCoreCodeFirstSample.Models.Entities.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("KitapTur", b =>
                {
                    b.HasOne("EFCoreCodeFirstSample.Models.Entities.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodeFirstSample.Models.Entities.Tur", null)
                        .WithMany()
                        .HasForeignKey("TurlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Entities.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}