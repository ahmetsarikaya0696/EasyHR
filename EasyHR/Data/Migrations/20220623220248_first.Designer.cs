﻿// <auto-generated />
using System;
using EasyHR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyHR.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220623220248_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyHR.Models.AvansTalep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<int>("AvansOnayDurumu")
                        .HasColumnType("int");

                    b.Property<decimal>("AvansTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PersonelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("SonuclanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TalepTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("AvansTalepleri");
                });

            modelBuilder.Entity("EasyHR.Models.HarcamaTalep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<string>("DosyaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HarcamaOnayDurumu")
                        .HasColumnType("int");

                    b.Property<decimal>("HarcamaTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PersonelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("SonuclanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TalepTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("HarcamaTalepleri");
                });

            modelBuilder.Entity("EasyHR.Models.IzinTalep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("IzinBaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IzinBitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("IzinGunSayisi")
                        .HasColumnType("int");

                    b.Property<int>("IzinOnayDurumu")
                        .HasColumnType("int");

                    b.Property<int>("IzinTuru")
                        .HasColumnType("int");

                    b.Property<string>("PersonelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("SonuclanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TalepTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("IzinTalepleri");
                });

            modelBuilder.Entity("EasyHR.Models.Meslek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MeslekAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MeslekKodu")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("Id");

                    b.ToTable("Meslekler");
                });

            modelBuilder.Entity("EasyHR.Models.Sirket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SirketAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SirketInfo")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EasyHR.Data.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotografAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IseGirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("IstenCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KanGrubu")
                        .HasColumnType("int");

                    b.Property<decimal>("Maas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MaksAvansHakki")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MedeniHali")
                        .HasColumnType("int");

                    b.Property<int>("MeslekId")
                        .HasColumnType("int");

                    b.Property<decimal>("MinAvansHakki")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<long>("Telefon")
                        .HasColumnType("bigint");

                    b.Property<int>("Unvan")
                        .HasColumnType("int");

                    b.Property<int>("YillikIzinGunSayisi")
                        .HasColumnType("int");

                    b.Property<string>("YoneticiId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("MeslekId");

                    b.HasIndex("SirketId");

                    b.HasIndex("YoneticiId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("EasyHR.Models.AvansTalep", b =>
                {
                    b.HasOne("EasyHR.Data.ApplicationUser", "Personel")
                        .WithMany("AvansTalepleri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("EasyHR.Models.HarcamaTalep", b =>
                {
                    b.HasOne("EasyHR.Data.ApplicationUser", "Personel")
                        .WithMany("HarcamaTalepleri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("EasyHR.Models.IzinTalep", b =>
                {
                    b.HasOne("EasyHR.Data.ApplicationUser", "Personel")
                        .WithMany("IzinTalepleri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyHR.Data.ApplicationUser", b =>
                {
                    b.HasOne("EasyHR.Models.Meslek", "Meslek")
                        .WithMany("Personel")
                        .HasForeignKey("MeslekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyHR.Models.Sirket", "Sirket")
                        .WithMany("Personeller")
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyHR.Data.ApplicationUser", "Yonetici")
                        .WithMany()
                        .HasForeignKey("YoneticiId");

                    b.Navigation("Meslek");

                    b.Navigation("Sirket");

                    b.Navigation("Yonetici");
                });

            modelBuilder.Entity("EasyHR.Models.Meslek", b =>
                {
                    b.Navigation("Personel");
                });

            modelBuilder.Entity("EasyHR.Models.Sirket", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("EasyHR.Data.ApplicationUser", b =>
                {
                    b.Navigation("AvansTalepleri");

                    b.Navigation("HarcamaTalepleri");

                    b.Navigation("IzinTalepleri");
                });
#pragma warning restore 612, 618
        }
    }
}
