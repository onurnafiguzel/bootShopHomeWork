﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bootShop.DataAccess.Data;

namespace bootShop.DataAccess.Migrations
{
    [DbContext(typeof(bootShopDbContext))]
    [Migration("20220426200543_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bootShop.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hikaye"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Romantik"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tarih"
                        });
                });

            modelBuilder.Entity("bootShop.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptipn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Ahmet Mithat Efendi",
                            CategoryId = 1,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000349750-1.jpg",
                            IsActive = true,
                            Name = "Felatun Bey ile Rakım Efendi",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 2,
                            Author = "John Steinbeck",
                            CategoryId = 1,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000411500-1.jpg",
                            IsActive = true,
                            Name = "Fareler ve İnsanlar",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 3,
                            Author = "Recaizade Mahmut Ekrem",
                            CategoryId = 1,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000387725-1.jpg",
                            IsActive = true,
                            Name = "Araba Sevdası",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 4,
                            Author = "Reşat Nuri Güntekin",
                            CategoryId = 1,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000052645-1.jpg",
                            IsActive = true,
                            Name = "Yaprak Dökümü",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 5,
                            Author = "Stephan Zweig",
                            CategoryId = 2,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000402142-1.jpg",
                            IsActive = true,
                            Name = "Satranç",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 6,
                            Author = "Asuman Toprak Deniz",
                            CategoryId = 2,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://1k-cdn.com/k/resimler/kitaplar/13199_5841e_1622924194.jpg",
                            IsActive = true,
                            Name = "Portakal Yokuşu",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 7,
                            Author = "Şermin Yaşar",
                            CategoryId = 2,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://1k-cdn.com/k/resimler/kitaplar/27823_8e141_1540595628.jpg",
                            IsActive = true,
                            Name = "Dedemin Bakkalı",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 8,
                            Author = "Stephan Zweig",
                            CategoryId = 2,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://1k-cdn.com/k/resimler/kitaplar/87436_ed3ae_1581022479.jpg",
                            IsActive = true,
                            Name = "Dönüşüm",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 9,
                            Author = "John Green",
                            CategoryId = 3,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000448031-1.jpg",
                            IsActive = true,
                            Name = "Aynı Yıldızın Altında",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 10,
                            Author = "Jojo Moyes",
                            CategoryId = 3,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000440466-1.jpg",
                            IsActive = true,
                            Name = "Senden Önce Ben",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 11,
                            Author = "Sabahattin Ali",
                            CategoryId = 3,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000058245-1.jpg",
                            IsActive = true,
                            Name = "Kürk Mantolu Madonna",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 12,
                            Author = "Mehmet Rauf",
                            CategoryId = 3,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000135815-1.jpg",
                            IsActive = true,
                            Name = "Eylül",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 13,
                            Author = "Grigory Petrov",
                            CategoryId = 4,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000250242-1.jpg",
                            IsActive = true,
                            Name = "Beyaz Zambaklar Ülkesinde",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 14,
                            Author = "Mustafa Kemal Atataürk",
                            CategoryId = 4,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000364370-1.jpg",
                            IsActive = true,
                            Name = "Nutuk",
                            Price = 1919.0
                        },
                        new
                        {
                            Id = 15,
                            Author = "İlber Ortaylı",
                            CategoryId = 4,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:5676840/wh:true/wi:800",
                            IsActive = true,
                            Name = "Türkiye'nin Yakın Tarihi",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 16,
                            Author = "Yuval Noah Harari",
                            CategoryId = 4,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:6682711/wh:true/wi:800",
                            IsActive = true,
                            Name = "21. Yüzyıl İçin 21 Ders",
                            Price = 20.0
                        });
                });

            modelBuilder.Entity("bootShop.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eposta = "ongguzel@gmail.com",
                            FullName = "Onur Güzel",
                            Password = "1234",
                            Role = "Admin",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Eposta = "user2@test.com",
                            FullName = "user two",
                            Password = "123",
                            Role = "Editor",
                            UserName = "user2"
                        },
                        new
                        {
                            Id = 3,
                            Eposta = "user3@test.com",
                            FullName = "user three",
                            Password = "123",
                            Role = "Client",
                            UserName = "user3"
                        });
                });

            modelBuilder.Entity("bootShop.Entities.Product", b =>
                {
                    b.HasOne("bootShop.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("bootShop.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}