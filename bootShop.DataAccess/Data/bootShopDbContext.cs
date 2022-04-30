using bootShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Data
{
    public class bootShopDbContext : DbContext
    {
        public bootShopDbContext(DbContextOptions<bootShopDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                  new Category
                  {
                      Id = 1,
                      Name = "Roman"

                  },
                  new Category
                  {
                      Id = 2,
                      Name = "Hikaye",
                  },
                  new Category { Id = 3, Name = "Romantik" },
                  new Category { Id = 4, Name = "Tarih" }

               );

            modelBuilder.Entity<Product>().HasData(

                           new Product { Id = 1, Name = "Felatun Bey ile Rakım Efendi", Author = "Ahmet Mithat Efendi", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000349750-1.jpg", CategoryId = 1 },
                           new Product { Id = 2, Name = "Fareler ve İnsanlar", Author = "John Steinbeck", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000411500-1.jpg", CategoryId = 1 },
                           new Product { Id = 3, Name = "Araba Sevdası", Author = "Recaizade Mahmut Ekrem", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000387725-1.jpg", CategoryId = 1 },
                           new Product { Id = 4, Name = "Yaprak Dökümü", Author = "Reşat Nuri Güntekin", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000052645-1.jpg", CategoryId = 1 },

                            new Product { Id = 5, Name = "Satranç", Author = "Stephan Zweig", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000402142-1.jpg", CategoryId = 2 },
                           new Product { Id = 6, Name = "Portakal Yokuşu", Author = "Asuman Toprak Deniz", Price = 20, Discount = 0.15, ImageUrl = "https://1k-cdn.com/k/resimler/kitaplar/13199_5841e_1622924194.jpg", CategoryId = 2 },
                           new Product { Id = 7, Name = "Dedemin Bakkalı", Author = "Şermin Yaşar", Price = 20, Discount = 0.15, ImageUrl = "https://1k-cdn.com/k/resimler/kitaplar/27823_8e141_1540595628.jpg", CategoryId = 2 },
                           new Product { Id = 8, Name = "Dönüşüm", Author = "Stephan Zweig", Price = 20, Discount = 0.15, ImageUrl = "https://1k-cdn.com/k/resimler/kitaplar/87436_ed3ae_1581022479.jpg", CategoryId = 2 },

                            new Product { Id = 9, Name = "Aynı Yıldızın Altında", Author = "John Green", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000448031-1.jpg", CategoryId = 3 },
                           new Product { Id = 10, Name = "Senden Önce Ben", Author = "Jojo Moyes", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000440466-1.jpg", CategoryId = 3 },
                           new Product { Id = 11, Name = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000058245-1.jpg", CategoryId = 3 },
                           new Product { Id = 12, Name = "Eylül", Author = "Mehmet Rauf", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000135815-1.jpg", CategoryId = 3 },



                           new Product { Id = 13, Name = "Beyaz Zambaklar Ülkesinde", Author = "Grigory Petrov", Price = 20, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000250242-1.jpg", CategoryId = 4 },
                           new Product { Id = 14, Name = "Nutuk", Author = "Mustafa Kemal Atataürk", Price = 1919, Discount = 0.15, ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000364370-1.jpg", CategoryId = 4 },
                           new Product { Id = 15, Name = "Türkiye'nin Yakın Tarihi", Author = "İlber Ortaylı", Price = 20, Discount = 0.15, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:5676840/wh:true/wi:800", CategoryId = 4 },
                           new Product { Id = 16, Name = "21. Yüzyıl İçin 21 Ders", Author = "Yuval Noah Harari", Price = 20, Discount = 0.15, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:6682711/wh:true/wi:800", CategoryId = 4 }
                           );

            modelBuilder.Entity<User>().HasData(
                        new User { Id = 1, FullName = "Onur Güzel", Eposta = "ongguzel@gmail.com", Password = "1234", Role = "Admin", UserName = "admin" },
                        new User { Id = 2, Eposta = "user2@test.com", FullName = "user two", Password = "123", UserName = "user2", Role = "Editor" },
                        new User { Id = 3, Eposta = "user3@test.com", FullName = "user three", Password = "123", UserName = "user3", Role = "Client" }
             );
        }
    }
}
