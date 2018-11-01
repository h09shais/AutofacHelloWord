using System;

namespace AutofacHelloWord
{
    public class SalesChannel : ISalesChannel
    {
        public string ShopId { get; }

        public SalesChannel(string shopId)
        {
            ShopId = shopId;
        }
    }
}
