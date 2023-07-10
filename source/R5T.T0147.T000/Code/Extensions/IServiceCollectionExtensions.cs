using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0147;


namespace System
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Calls the <see cref="IServiceAction.Run(IServiceCollection)"/> method on the service collection.
        /// </summary>
        public static IServiceCollection RunServiceAction<TService>(this IServiceCollection services, IServiceAction<TService> serviceAction)
        {
            serviceAction.Run(services);

            return services;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="IServiceCollectionExtensions.RunServiceAction{T}(IServiceCollection, IServiceAction{T})"/>.
        /// </summary>
        public static IServiceCollection Run<TService>(this IServiceCollection services, IServiceAction<TService> serviceAction)
        {
            services.RunServiceAction(serviceAction);

            return services;
        }
    }
}
