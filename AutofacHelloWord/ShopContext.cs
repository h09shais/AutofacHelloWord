namespace AutofacHelloWord
{
    public class ShopContext : IShopContext
    {
        public string ShopId { get; }

        public ShopContext(string shopId)
        {
            ShopId = shopId;
        }
    }
}
