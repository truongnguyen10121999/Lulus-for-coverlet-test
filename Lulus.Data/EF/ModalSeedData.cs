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
        }
    }
}
