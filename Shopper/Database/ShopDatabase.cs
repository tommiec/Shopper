namespace Shopper.Database
{
    public class ShopDatabase : IShopDatabase
    {
        private ShopDbContext shopDbContext;
        
        public ShopDatabase(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

    }
}
