using Lulus.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.EF
{
    public static class ModalSeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    Email = "annalee@shop.com",
                    NormalizedEmail = "ANNALEE@SHOP.COM",
                    UserName = "annalee",
                    NormalizedUserName = "ANNALEE",
                    PhoneNumber = "012545454541",
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    Customer_FirstName = "Anna",
                    Customer_LastName = "Lee",
                    Customer_Address = "22 St. Wall Street, Brooklyn, American",
                    SecurityStamp = "NQLC7NG4A7DTOJ5DETPA35OHKTOZMMYP"
                }
                );
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>
                {
                    Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<Guid>
                {
                    Id = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D"),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    RoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Category_ID = 1,
                    Category_Name = "Dresses"
                },
                new Category()
                {
                    Category_ID = 2,
                    Category_Name = "Tops"
                },
                new Category()
                {
                    Category_ID = 3,
                    Category_Name = "Bottoms"
                },
                new Category()
                {
                    Category_ID = 4,
                    Category_Name = "Activewear"
                },
                new Category()
                {
                    Category_ID = 5,
                    Category_Name = "Swimwear"
                },
                new Category()
                {
                    Category_ID = 6,
                    Category_Name = "Outerwear"
                },
                new Category()
                {
                    Category_ID = 7,
                    Category_Name = "Rompers and Jumpsuits"
                },
                new Category()
                {
                    Category_ID = 8,
                    Category_Name = "Denims"
                },
                new Category()
                {
                    Category_ID = 9,
                    Category_Name = "Loungewears"
                }
                );
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory()
                {
                    SubCategory_ID = 1,
                    SubCategory_Name = "A-Line",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 2,
                    SubCategory_Name = "Asymmetric",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 3,
                    SubCategory_Name = "Bodycon",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 4,
                    SubCategory_Name = "Column",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 5,
                    SubCategory_Name = "Empire",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 6,
                    SubCategory_Name = "Shift",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 7,
                    SubCategory_Name = "Skater",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 8,
                    SubCategory_Name = "Tiered",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 9,
                    SubCategory_Name = "Trumpet",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 10,
                    SubCategory_Name = "Tulip",
                    Category_ID = 1,
                },
                new SubCategory()
                {
                    SubCategory_ID = 11,
                    SubCategory_Name = "Apron",
                    Category_ID = 2,
                },
                new SubCategory()
                {
                    SubCategory_ID = 12,
                    SubCategory_Name = "Boat Neck",
                    Category_ID = 2,
                },
                new SubCategory()
                {
                    SubCategory_ID = 13,
                    SubCategory_Name = "Collared",
                    Category_ID = 2,
                },
                new SubCategory()
                {
                    SubCategory_ID = 14,
                    SubCategory_Name = "Convertible",
                    Category_ID = 2,
                },
                new SubCategory()
                {
                    SubCategory_ID = 15,
                    SubCategory_Name = "Cowl",
                    Category_ID = 2,
                },
                new SubCategory()
                {
                    SubCategory_ID = 16,
                    SubCategory_Name = "A-Line",
                    Category_ID = 3,
                },
                new SubCategory()
                {
                    SubCategory_ID = 17,
                    SubCategory_Name = "Asymmetrical",
                    Category_ID = 3,
                },
                new SubCategory()
                {
                    SubCategory_ID = 18,
                    SubCategory_Name = "Bodycon",
                    Category_ID = 3,
                },
                new SubCategory()
                {
                    SubCategory_ID = 19,
                    SubCategory_Name = "Boyfriend",
                    Category_ID = 3,
                },
                new SubCategory()
                {
                    SubCategory_ID = 20,
                    SubCategory_Name = "Cullote",
                    Category_ID = 3,
                },
                new SubCategory()
                {
                    SubCategory_ID = 21,
                    SubCategory_Name = "Halter",
                    Category_ID = 4,
                },
                new SubCategory()
                {
                    SubCategory_ID = 22,
                    SubCategory_Name = "High-Neck",
                    Category_ID = 4,
                },
                new SubCategory()
                {
                    SubCategory_ID = 23,
                    SubCategory_Name = "One-Shoulder",
                    Category_ID = 4,
                },
                new SubCategory()
                {
                    SubCategory_ID = 24,
                    SubCategory_Name = "Round-Neck",
                    Category_ID = 4,
                },
                new SubCategory()
                {
                    SubCategory_ID = 25,
                    SubCategory_Name = "Scoop",
                    Category_ID = 4,
                },
                new SubCategory()
                {
                    SubCategory_ID = 26,
                    SubCategory_Name = "Coverups",
                    Category_ID = 5,
                },
                new SubCategory()
                {
                    SubCategory_ID = 27,
                    SubCategory_Name = "One Piece Swimsuits",
                    Category_ID = 5,
                },
                new SubCategory()
                {
                    SubCategory_ID = 28,
                    SubCategory_Name = "Swimsuit Bottoms",
                    Category_ID = 5,
                },
                new SubCategory()
                {
                    SubCategory_ID = 29,
                    SubCategory_Name = "Swimsuit Tops",
                    Category_ID = 5,
                },
                new SubCategory()
                {
                    SubCategory_ID = 30,
                    SubCategory_Name = "Bandeau",
                    Category_ID = 5,
                },
                new SubCategory()
                {
                    SubCategory_ID = 31,
                    SubCategory_Name = "Blazers",
                    Category_ID = 6,
                },
                new SubCategory()
                {
                    SubCategory_ID = 32,
                    SubCategory_Name = "Coats",
                    Category_ID = 6,
                },
                new SubCategory()
                {
                    SubCategory_ID = 33,
                    SubCategory_Name = "Denim Jackets",
                    Category_ID = 6,
                },
                new SubCategory()
                {
                    SubCategory_ID = 34,
                    SubCategory_Name = "Jackets",
                    Category_ID = 6,
                },
                new SubCategory()
                {
                    SubCategory_ID = 35,
                    SubCategory_Name = "Collared",
                    Category_ID = 6,
                },
                new SubCategory()
                {
                    SubCategory_ID = 36,
                    SubCategory_Name = "Apron",
                    Category_ID = 7,
                },
                new SubCategory()
                {
                    SubCategory_ID = 37,
                    SubCategory_Name = "Boat Neck",
                    Category_ID = 7,
                },
                new SubCategory()
                {
                    SubCategory_ID = 38,
                    SubCategory_Name = "Collared",
                    Category_ID = 7,
                },
                new SubCategory()
                {
                    SubCategory_ID = 39,
                    SubCategory_Name = "Halter",
                    Category_ID = 7,
                },
                new SubCategory()
                {
                    SubCategory_ID = 40,
                    SubCategory_Name = "Mock",
                    Category_ID = 7,
                },
                new SubCategory()
                {
                    SubCategory_ID = 41,
                    SubCategory_Name = "Boyfriend",
                    Category_ID = 8,
                },
                new SubCategory()
                {
                    SubCategory_ID = 42,
                    SubCategory_Name = "Cut Off",
                    Category_ID = 8,
                },
                new SubCategory()
                {
                    SubCategory_ID = 43,
                    SubCategory_Name = "Flare",
                    Category_ID = 8,
                },
                new SubCategory()
                {
                    SubCategory_ID = 44,
                    SubCategory_Name = "Mom",
                    Category_ID = 8,
                },
                new SubCategory()
                {
                    SubCategory_ID = 45,
                    SubCategory_Name = "Skinny",
                    Category_ID = 8,
                },
                new SubCategory()
                {
                    SubCategory_ID = 46,
                    SubCategory_Name = "Boat Neck",
                    Category_ID = 9,
                },
                new SubCategory()
                {
                    SubCategory_ID = 47,
                    SubCategory_Name = "Collared",
                    Category_ID = 9,
                },
                new SubCategory()
                {
                    SubCategory_ID = 48,
                    SubCategory_Name = "High-Neck",
                    Category_ID = 9,
                },
                new SubCategory()
                {
                    SubCategory_ID = 49,
                    SubCategory_Name = "Mock",
                    Category_ID = 9,
                },
                new SubCategory()
                {
                    SubCategory_ID = 50,
                    SubCategory_Name = "Scoop",
                    Category_ID = 9,
                }
                );
            modelBuilder.Entity<Size>().HasData(
                new Size()
                {
                    Size_ID = 1,
                    Size_Key = "XXS"
                },
                new Size()
                {
                    Size_ID = 2,
                    Size_Key = "XS"
                },
                new Size()
                {
                    Size_ID = 3,
                    Size_Key = "S"
                },
                new Size()
                {
                    Size_ID = 4,
                    Size_Key = "M"
                },
                new Size()
                {
                    Size_ID = 5,
                    Size_Key = "L"
                },
                new Size()
                {
                    Size_ID = 6,
                    Size_Key = "XL"
                },
                new Size()
                {
                    Size_ID = 7,
                    Size_Key = "1X"
                },
                new Size()
                {
                    Size_ID = 8,
                    Size_Key = "2X"
                },
                new Size()
                {
                    Size_ID = 9,
                    Size_Key = "3X"
                }
                );
            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    Country_ID = 1,
                    Country_Name = "Vietnam"
                },
                new Country()
                {
                    Country_ID = 2,
                    Country_Name = "American"
                },
                new Country()
                {
                    Country_ID = 3,
                    Country_Name = "England"
                },
                new Country()
                {
                    Country_ID = 4,
                    Country_Name = "France"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Product_ID = 1,
                    Product_Name = "Wondrous Water Lilies Royal Blue Maxi Dress",
                    Product_Price = 68,
                    Product_SalePrice = 68,
                    Product_Description = "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.",
                    SubCategory_ID = 1,
                    Status = Enums.ProductStatus.Stocking
                },
                new Product()
                {
                    Product_ID = 2,
                    Product_Name = "Thoughts of Hue Black Surplice Maxi Dress",
                    Product_Price = 88,
                    Product_SalePrice = 80,
                    Product_Description = "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.",
                    SubCategory_ID = 1,
                    Status = Enums.ProductStatus.Stocking
                },
                new Product()
                {
                    Product_ID = 3,
                    Product_Name = "Thoughts of Hue Black Surplice Maxi Dress",
                    Product_Price = 88,
                    Product_SalePrice = 80,
                    Product_Description = "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.",
                    SubCategory_ID = 2,
                    Status = Enums.ProductStatus.Stocking
                },
                new Product()
                {
                    Product_ID = 4,
                    Product_Name = "Thoughts of Hue Black Surplice Maxi Dress",
                    Product_Price = 88,
                    Product_SalePrice = 80,
                    Product_Description = "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.",
                    SubCategory_ID = 3,
                    Status = Enums.ProductStatus.Stocking
                },
                new Product()
                {
                    Product_ID = 5,
                    Product_Name = "Thoughts of Hue Black Surplice Maxi Dress",
                    Product_Price = 88,
                    Product_SalePrice = 80,
                    Product_Description = "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.",
                    SubCategory_ID = 4,
                    Status = Enums.ProductStatus.Stocking
                },
                new Product()
                {
                    Product_ID = 6,
                    Product_Name = "Thoughts of Hue Black Surplice Maxi Dress",
                    Product_Price = 88,
                    Product_SalePrice = 80,
                    Product_Description = "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.",
                    SubCategory_ID = 5,
                    Status = Enums.ProductStatus.Stocking
                }
                );
            var baseImageUrl = "/Images/Product";
            modelBuilder.Entity<ProductLine>().HasData(
                new ProductLine()
                {
                    ProductLine_ID = 1,
                    Texture_Name = "Navy Blue",
                    Texture_Image = baseImageUrl + "/texture/navy-blue.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 1
                },
                new ProductLine()
                {
                    ProductLine_ID = 2,
                    Texture_Name = "Green",
                    Texture_Image = baseImageUrl + "/texture/green.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 1
                },
                new ProductLine()
                {
                    ProductLine_ID = 3,
                    Texture_Name = "Mustard Yellow Floral Print",
                    Texture_Image = baseImageUrl + "/texture/mustard-yellow-floral-print.jpg",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 2
                },
                new ProductLine()
                {
                    ProductLine_ID = 4,
                    Texture_Name = "Red Floral Print",
                    Texture_Image = baseImageUrl + "/texture/red-floral-print.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 2
                },
                new ProductLine()
                {
                    ProductLine_ID = 5,
                    Texture_Name = "Navy Blue Floral Print",
                    Texture_Image = baseImageUrl + "/texture/navy-blue-floral-print.jpg",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 2
                },
                new ProductLine()
                {
                    ProductLine_ID = 6,
                    Texture_Name = "Red",
                    Texture_Image = baseImageUrl + "/texture/red.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 3
                },
                new ProductLine()
                {
                    ProductLine_ID = 7,
                    Texture_Name = "White",
                    Texture_Image = baseImageUrl + "/texture/white.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 3
                },
                new ProductLine()
                {
                    ProductLine_ID = 8,
                    Texture_Name = "Royal White",
                    Texture_Image = baseImageUrl + "/texture/royal-white.jpg",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 4
                },
                new ProductLine()
                {
                    ProductLine_ID = 9,
                    Texture_Name = "Royal Blue",
                    Texture_Image = baseImageUrl + "/texture/royal-blue.jpg",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 4
                },
                new ProductLine()
                {
                    ProductLine_ID = 10,
                    Texture_Name = "Burgundy",
                    Texture_Image = baseImageUrl + "/texture/burgundy.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 5
                },
                new ProductLine()
                {
                    ProductLine_ID = 11,
                    Texture_Name = "Purple",
                    Texture_Image = baseImageUrl + "/texture/purple.jpg",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 6
                },
                new ProductLine()
                {
                    ProductLine_ID = 12,
                    Texture_Name = "Burgundy",
                    Texture_Image = baseImageUrl + "/texture/burgundy.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 6
                },
                new ProductLine()
                {
                    ProductLine_ID = 13,
                    Texture_Name = "Green",
                    Texture_Image = baseImageUrl + "/texture/green.png",
                    ProductLine_CreatedDate = DateTime.Now,
                    ProductLine_UpdatedDate = DateTime.Now,
                    Product_ID = 6
                }
                );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    ProductImage_ID = 1,
                    ProductLine_ID = 1,
                    ProductImage_Image = baseImageUrl + "/1-0.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 2,
                    ProductLine_ID = 1,
                    ProductImage_Image = baseImageUrl + "/1-1.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 3,
                    ProductLine_ID = 1,
                    ProductImage_Image = baseImageUrl + "/1-2.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 4,
                    ProductLine_ID = 1,
                    ProductImage_Image = baseImageUrl + "/1-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 5,
                    ProductLine_ID = 1,
                    ProductImage_Image = baseImageUrl + "/1-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 6,
                    ProductLine_ID = 2,
                    ProductImage_Image = baseImageUrl + "/2-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 7,
                    ProductLine_ID = 2,
                    ProductImage_Image = baseImageUrl + "/2-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 8,
                    ProductLine_ID = 2,
                    ProductImage_Image = baseImageUrl + "/2-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 9,
                    ProductLine_ID = 2,
                    ProductImage_Image = baseImageUrl + "/2-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 10,
                    ProductLine_ID = 2,
                    ProductImage_Image = baseImageUrl + "/2-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 11,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 12,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 13,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 14,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 15,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 16,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-5.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 17,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-6.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 18,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-7.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 19,
                    ProductLine_ID = 3,
                    ProductImage_Image = baseImageUrl + "/3-8.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 20,
                    ProductLine_ID = 4,
                    ProductImage_Image = baseImageUrl + "/4-0.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 21,
                    ProductLine_ID = 4,
                    ProductImage_Image = baseImageUrl + "/4-1.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 22,
                    ProductLine_ID = 4,
                    ProductImage_Image = baseImageUrl + "/4-2.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 23,
                    ProductLine_ID = 4,
                    ProductImage_Image = baseImageUrl + "/4-3.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 24,
                    ProductLine_ID = 4,
                    ProductImage_Image = baseImageUrl + "/4-4.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 25,
                    ProductLine_ID = 4,
                    ProductImage_Image = baseImageUrl + "/4-5.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 26,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-1.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 27,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-2.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 28,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-3.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 29,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-4.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 30,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-5.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 31,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-6.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 32,
                    ProductLine_ID = 5,
                    ProductImage_Image = baseImageUrl + "/5-7.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 33,
                    ProductLine_ID = 6,
                    ProductImage_Image = baseImageUrl + "/6-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 34,
                    ProductLine_ID = 6,
                    ProductImage_Image = baseImageUrl + "/6-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 35,
                    ProductLine_ID = 6,
                    ProductImage_Image = baseImageUrl + "/6-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 36,
                    ProductLine_ID = 6,
                    ProductImage_Image = baseImageUrl + "/6-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 37,
                    ProductLine_ID = 7,
                    ProductImage_Image = baseImageUrl + "/7-0.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 38,
                    ProductLine_ID = 7,
                    ProductImage_Image = baseImageUrl + "/7-1.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 39,
                    ProductLine_ID = 7,
                    ProductImage_Image = baseImageUrl + "/7-2.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 40,
                    ProductLine_ID = 7,
                    ProductImage_Image = baseImageUrl + "/7-3.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 41,
                    ProductLine_ID = 7,
                    ProductImage_Image = baseImageUrl + "/7-4.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 42,
                    ProductLine_ID = 7,
                    ProductImage_Image = baseImageUrl + "/7-5.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 43,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 44,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 45,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 46,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 47,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 48,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-5.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 49,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-6.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 50,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-7.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 51,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-8.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 52,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-9.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 53,
                    ProductLine_ID = 8,
                    ProductImage_Image = baseImageUrl + "/8-10.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 54,
                    ProductLine_ID = 9,
                    ProductImage_Image = baseImageUrl + "/9-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 55,
                    ProductLine_ID = 9,
                    ProductImage_Image = baseImageUrl + "/9-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 56,
                    ProductLine_ID = 9,
                    ProductImage_Image = baseImageUrl + "/9-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 57,
                    ProductLine_ID = 9,
                    ProductImage_Image = baseImageUrl + "/9-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 58,
                    ProductLine_ID = 9,
                    ProductImage_Image = baseImageUrl + "/9-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 59,
                    ProductLine_ID = 10,
                    ProductImage_Image = baseImageUrl + "/10-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 60,
                    ProductLine_ID = 10,
                    ProductImage_Image = baseImageUrl + "/10-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 61,
                    ProductLine_ID = 10,
                    ProductImage_Image = baseImageUrl + "/10-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 62,
                    ProductLine_ID = 10,
                    ProductImage_Image = baseImageUrl + "/10-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 63,
                    ProductLine_ID = 11,
                    ProductImage_Image = baseImageUrl + "/11-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 64,
                    ProductLine_ID = 11,
                    ProductImage_Image = baseImageUrl + "/11-1.jpg"
                },
                new ProductImage()
                {
                    ProductImage_ID = 65,
                    ProductLine_ID = 11,
                    ProductImage_Image = baseImageUrl + "/11-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 66,
                    ProductLine_ID = 11,
                    ProductImage_Image = baseImageUrl + "/11-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 67,
                    ProductLine_ID = 11,
                    ProductImage_Image = baseImageUrl + "/11-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 68,
                    ProductLine_ID = 12,
                    ProductImage_Image = baseImageUrl + "/12-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 69,
                    ProductLine_ID = 12,
                    ProductImage_Image = baseImageUrl + "/12-1.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 70,
                    ProductLine_ID = 12,
                    ProductImage_Image = baseImageUrl + "/12-2.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 71,
                    ProductLine_ID = 12,
                    ProductImage_Image = baseImageUrl + "/12-3.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 72,
                    ProductLine_ID = 12,
                    ProductImage_Image = baseImageUrl + "/12-4.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 73,
                    ProductLine_ID = 13,
                    ProductImage_Image = baseImageUrl + "/13-0.png"
                },
                new ProductImage()
                {
                    ProductImage_ID = 74,
                    ProductLine_ID = 13,
                    ProductImage_Image = baseImageUrl + "/13-1.png"
                }
                );
            modelBuilder.Entity<LineQuantity>().HasData(
                new LineQuantity()
                {
                    LineQuantity_ID = 1,
                    ProductLine_ID = 1,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 2,
                    ProductLine_ID = 1,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 3,
                    ProductLine_ID = 1,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 4,
                    ProductLine_ID = 1,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 5,
                    ProductLine_ID = 1,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 6,
                    ProductLine_ID = 1,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 7,
                    ProductLine_ID = 2,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 8,
                    ProductLine_ID = 2,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 9,
                    ProductLine_ID = 2,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 10,
                    ProductLine_ID = 2,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 11,
                    ProductLine_ID = 2,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 13,
                    ProductLine_ID = 2,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 14,
                    ProductLine_ID = 3,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 15,
                    ProductLine_ID = 3,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 16,
                    ProductLine_ID = 3,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 17,
                    ProductLine_ID = 3,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 18,
                    ProductLine_ID = 3,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 19,
                    ProductLine_ID = 3,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 20,
                    ProductLine_ID = 4,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 21,
                    ProductLine_ID = 4,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 22,
                    ProductLine_ID = 4,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 23,
                    ProductLine_ID = 4,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 24,
                    ProductLine_ID = 4,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 25,
                    ProductLine_ID = 4,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 26,
                    ProductLine_ID = 5,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 27,
                    ProductLine_ID = 5,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 28,
                    ProductLine_ID = 5,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 29,
                    ProductLine_ID = 5,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 30,
                    ProductLine_ID = 5,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 31,
                    ProductLine_ID = 5,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 32,
                    ProductLine_ID = 6,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 33,
                    ProductLine_ID = 6,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 34,
                    ProductLine_ID = 6,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 35,
                    ProductLine_ID = 6,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 36,
                    ProductLine_ID = 6,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 37,
                    ProductLine_ID = 6,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 38,
                    ProductLine_ID = 7,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 39,
                    ProductLine_ID = 7,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 40,
                    ProductLine_ID = 7,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 41,
                    ProductLine_ID = 7,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 42,
                    ProductLine_ID = 7,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 43,
                    ProductLine_ID = 7,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 44,
                    ProductLine_ID = 8,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 45,
                    ProductLine_ID = 8,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 46,
                    ProductLine_ID = 8,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 47,
                    ProductLine_ID = 8,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 48,
                    ProductLine_ID = 8,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 49,
                    ProductLine_ID = 8,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 50,
                    ProductLine_ID = 9,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 51,
                    ProductLine_ID = 9,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 52,
                    ProductLine_ID = 9,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 53,
                    ProductLine_ID = 9,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 54,
                    ProductLine_ID = 9,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 55,
                    ProductLine_ID = 9,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 56,
                    ProductLine_ID = 10,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 57,
                    ProductLine_ID = 10,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 58,
                    ProductLine_ID = 10,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 59,
                    ProductLine_ID = 10,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 60,
                    ProductLine_ID = 10,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 61,
                    ProductLine_ID = 10,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 62,
                    ProductLine_ID = 11,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 63,
                    ProductLine_ID = 11,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 64,
                    ProductLine_ID = 11,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 65,
                    ProductLine_ID = 11,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 66,
                    ProductLine_ID = 11,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 67,
                    ProductLine_ID = 11,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 68,
                    ProductLine_ID = 12,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 69,
                    ProductLine_ID = 12,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 70,
                    ProductLine_ID = 12,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 71,
                    ProductLine_ID = 12,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 72,
                    ProductLine_ID = 12,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 73,
                    ProductLine_ID = 12,
                    Size_ID = 6,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 74,
                    ProductLine_ID = 13,
                    Size_ID = 1,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 75,
                    ProductLine_ID = 13,
                    Size_ID = 2,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 76,
                    ProductLine_ID = 13,
                    Size_ID = 3,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 77,
                    ProductLine_ID = 13,
                    Size_ID = 4,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 78,
                    ProductLine_ID = 13,
                    Size_ID = 5,
                    Quantity = 50
                },
                new LineQuantity()
                {
                    LineQuantity_ID = 79,
                    ProductLine_ID = 13,
                    Size_ID = 6,
                    Quantity = 50
                }
                );
        }
    }
}
