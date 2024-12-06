using Mapster;

using System.Reflection;

namespace FIQ.Interview.Api.Unility
{
    public static class MapsterConfig
    {
        public static void RegisterMapsterConfiguration(this IServiceCollection services)
        {
            //TypeAdapterConfig<OrderItem, OrderItemShortInfoDto>
            //.NewConfig()
            //.Map(dest => dest.ProductName, src => src.ProductName)
            //.Map(dest => dest.Quantity, src => src.Quantity);

            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        }
    }
}
