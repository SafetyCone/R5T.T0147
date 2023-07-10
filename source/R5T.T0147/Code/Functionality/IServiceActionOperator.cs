using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0132;


namespace R5T.T0147
{
	[FunctionalityMarker]
	public partial interface IServiceActionOperator : IFunctionalityMarker
	{
        /// <summary>
        /// Calls the <see cref="IServiceAction.Run(IServiceCollection)"/> method on the service collection.
        /// </summary>
        public IServiceCollection RunServiceAction<TService>(IServiceCollection services, IServiceAction<TService> serviceAction)
        {
            // Use extension method.
            services.RunServiceAction(serviceAction);

            return services;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="IServiceCollectionExtensions.RunServiceAction{T}(IServiceCollection, IServiceAction{T})"/>.
        /// </summary>
        public IServiceCollection Run<TService>(IServiceCollection services, IServiceAction<TService> serviceAction)
        {
            // Use extension method.
            services.Run(serviceAction);

            return services;
        }

        /// <summary>
        /// Constructor for <see cref="RunOnceServiceAction{TService}"/>.
        /// </summary>
        public IServiceAction<TService> NewRunOnce<TService>(Action<IServiceCollection> servicesAction)
        {
            var output = new RunOnceServiceAction<TService>(servicesAction);
            return output;
        }

        /// <summary>
        /// Chooses run-once (<see cref="RunOnceServiceAction{TService}"/>) as the default implementation for <see cref="IServiceAction{TService}"/> instances.
        /// </summary>
        public IServiceAction<TService> New<TService>(Action<IServiceCollection> servicesAction)
        {
            var serviceAction = this.NewRunOnce<TService>(servicesAction);
            return serviceAction;
        }
    }
}