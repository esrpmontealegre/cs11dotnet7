using Demo.Shared;

namespace Shopee.Common.UnitTests
{
//Connect to db
//confirm 8 columns
    public class EntityModelTests
    {
        [Fact]
        public void DatabaseConnectTest()
        {
            using (ShopeeContext db = new())
            {
                Assert.True(db.Database.CanConnect());
            }
        }
        [Fact]
        public void CategoryCountTest()
        {
            using (ShopeeContext db = new())
            {
                int expected = 8;
                int actual = db.Categories.Count();
                Assert.Equal(expected, actual);
            }
        }
    }
}