using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bootShop.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Descriptipn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Roman" },
                    { 2, "Hikaye" },
                    { 3, "Romantik" },
                    { 4, "Tarih" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Eposta", "FullName", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "ongguzel@gmail.com", "Onur Güzel", "1234", "Admin", "admin" },
                    { 2, "user2@test.com", "user two", "123", "Editor", "user2" },
                    { 3, "user3@test.com", "user three", "123", "Client", "user3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "CreatedDate", "Descriptipn", "Discount", "ImageUrl", "IsActive", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ahmet Mithat Efendi", 1, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000349750-1.jpg", true, null, "Felatun Bey ile Rakım Efendi", 20.0 },
                    { 2, "John Steinbeck", 1, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000411500-1.jpg", true, null, "Fareler ve İnsanlar", 20.0 },
                    { 3, "Recaizade Mahmut Ekrem", 1, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000387725-1.jpg", true, null, "Araba Sevdası", 20.0 },
                    { 4, "Reşat Nuri Güntekin", 1, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000052645-1.jpg", true, null, "Yaprak Dökümü", 20.0 },
                    { 5, "Stephan Zweig", 2, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000402142-1.jpg", true, null, "Satranç", 20.0 },
                    { 6, "Asuman Toprak Deniz", 2, null, null, 0.14999999999999999, "https://1k-cdn.com/k/resimler/kitaplar/13199_5841e_1622924194.jpg", true, null, "Portakal Yokuşu", 20.0 },
                    { 7, "Şermin Yaşar", 2, null, null, 0.14999999999999999, "https://1k-cdn.com/k/resimler/kitaplar/27823_8e141_1540595628.jpg", true, null, "Dedemin Bakkalı", 20.0 },
                    { 8, "Stephan Zweig", 2, null, null, 0.14999999999999999, "https://1k-cdn.com/k/resimler/kitaplar/87436_ed3ae_1581022479.jpg", true, null, "Dönüşüm", 20.0 },
                    { 9, "John Green", 3, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000448031-1.jpg", true, null, "Aynı Yıldızın Altında", 20.0 },
                    { 10, "Jojo Moyes", 3, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000440466-1.jpg", true, null, "Senden Önce Ben", 20.0 },
                    { 11, "Sabahattin Ali", 3, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000058245-1.jpg", true, null, "Kürk Mantolu Madonna", 20.0 },
                    { 12, "Mehmet Rauf", 3, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000135815-1.jpg", true, null, "Eylül", 20.0 },
                    { 13, "Grigory Petrov", 4, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000250242-1.jpg", true, null, "Beyaz Zambaklar Ülkesinde", 20.0 },
                    { 14, "Mustafa Kemal Atataürk", 4, null, null, 0.14999999999999999, "https://i.dr.com.tr/cache/500x400-0/originals/0000000364370-1.jpg", true, null, "Nutuk", 1919.0 },
                    { 15, "İlber Ortaylı", 4, null, null, 0.14999999999999999, "https://img.kitapyurdu.com/v1/getImage/fn:5676840/wh:true/wi:800", true, null, "Türkiye'nin Yakın Tarihi", 20.0 },
                    { 16, "Yuval Noah Harari", 4, null, null, 0.14999999999999999, "https://img.kitapyurdu.com/v1/getImage/fn:6682711/wh:true/wi:800", true, null, "21. Yüzyıl İçin 21 Ders", 20.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
