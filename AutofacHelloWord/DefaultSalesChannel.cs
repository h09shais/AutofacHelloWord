using System;

namespace AutofacHelloWord
{
    public class DefaultSalesChannel : SalesChannel
    {
        private const string DefaultShopId = "14662680-0CFC-40A9-989F-5E1763BE7D83";

        public DefaultSalesChannel() 
            : base(DefaultShopId)
        {
        }
    }
}