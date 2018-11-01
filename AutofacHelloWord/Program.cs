using System;
using Autofac;
using Autofac.Multitenant;

namespace AutofacHelloWord
{
    public class Program
    {
        private static ShopIdentifier _shopIdentifier;

        public static void Main()
        {
            _shopIdentifier = new ShopIdentifier("B6092811-20D0-447E-8849-2B41062CB624");
            ConfigureDependencies();

            Console.ReadKey();
        }

        private static void ConfigureDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Shop>().As<IShop>().InstancePerDependency();
            builder.RegisterType<SalesChannel>().As<ISalesChannel>().SingleInstance();

            var appContainer = builder.Build();
            var shopContainer = new MultitenantContainer(_shopIdentifier, appContainer);

            shopContainer.ConfigureTenant("B6092811-20D0-447E-8849-2B41062CB624", src => src.RegisterType<SalesChannelEast>().As<ISalesChannel>().SingleInstance());
            shopContainer.ConfigureTenant("A34A3B32-641B-41FF-9F6D-4690D5FDD897", src => src.RegisterType<SalesChannelWest>().As<ISalesChannel>().SingleInstance());
            shopContainer.ConfigureTenant("14662680-0CFC-40A9-989F-5E1763BE7D83", src => src.RegisterType<DefaultSalesChannel>().As<ISalesChannel>().SingleInstance());

            var application = shopContainer.Resolve<IShop>();
            Console.WriteLine($"Sales channel:{application.SalesChannel.GetType().Name}");
        }
    }
}
