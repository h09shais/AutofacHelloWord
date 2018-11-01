using System;

namespace AutofacHelloWord
{
    public class SalesChannelEast : SalesChannel
    {
        private const string EastShopId = "B6092811-20D0-447E-8849-2B41062CB624";

        public SalesChannelEast() 
            : base(EastShopId)
        {
        }
    }
}