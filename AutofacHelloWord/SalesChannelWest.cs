namespace AutofacHelloWord
{
    public class SalesChannelWest : SalesChannel
    {
        private const string WestShopId = "A34A3B32-641B-41FF-9F6D-4690D5FDD897";

        public SalesChannelWest() 
            : base(WestShopId)
        {
        }
    }
}