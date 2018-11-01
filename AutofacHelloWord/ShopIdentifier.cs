using Autofac.Multitenant;

namespace AutofacHelloWord
{
    public class ShopIdentifier : ITenantIdentificationStrategy
    {
        public string ShopId { get; }
        public ShopIdentifier(string shopId)
        {
            ShopId = shopId;
        }
        public bool TryIdentifyTenant(out object shopId)
        {
            shopId = this.ShopId;
            return true;
        }
    }
}
