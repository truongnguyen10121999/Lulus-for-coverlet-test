using Lulus.BAL.Catalog.Categories;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lulus.UnitTests.BAL.Products
{
    public class ProductTest
    {
        [Fact]
        public async Task GetAllProducts_Success_WithoutData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            var service = new CategoryService(dbcontext);

            var result = await service.GetAllProducts();

            Assert.Empty(result);
        }
        [Fact]
        public async Task GetAllProductViewModel_Success_WithData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name="Pants",
                Product_Price=12,
                Product_SalePrice=20,
                SubCategory_ID=1,
            }); 
            await dbcontext.SaveChangesAsync();

            var service = new CategoryService(dbcontext);

            var result = await service.GetAllProducts();

            Assert.Equal(1, result.First().ID);
            Assert.Equal("Pants", result.First().Name);
        }
    }
}
