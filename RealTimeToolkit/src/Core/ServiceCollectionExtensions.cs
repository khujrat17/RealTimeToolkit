#if NET8_0_OR_GREATER || NET7_0_OR_GREATER
using Microsoft.Extensions.DependencyInjection;
#endif

namespace RealTimeToolkit.Core
{
    public static class ServiceCollectionExtensions
    {
#if NET8_0_OR_GREATER || NET7_0_OR_GREATER
        public static IServiceCollection AddRealTimeToolkit(this IServiceCollection services)
        {
            services.AddSingleton<SignalRConnectionManager>();
            services.AddScoped<MessageBus>();
            return services;
        }
#else
        // For .NET Framework — no IServiceCollection, manual registration in Global.asax
        public static void InitializeRealTimeToolkit()
        {
            // No-op for backward compatibility
        }
#endif
    }
}
