namespace AutofacHelloWord
{
    public class Shop : IShop
    {
        public ISalesChannel SalesChannel { get; }

        public Shop(ISalesChannel salesChannel)
        {
            this.SalesChannel = salesChannel;
        }
    }
}
