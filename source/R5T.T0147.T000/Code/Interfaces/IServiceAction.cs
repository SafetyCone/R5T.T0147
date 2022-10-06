using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0142;


namespace R5T.T0147
{
    /// <summary>
    /// Encapsulates the addition of a service <typeparamref name="TService"/> to an <see cref="IServiceCollection"/> instance.
    /// The action must be run to actually add the service.
    /// Services actions are useful for communicating service dependency relationships while configuring a services collection.
    /// </summary>
    /// <typeparam name="TService">
    /// The service type, which can be either a service definition or service implementation, an interface or a class.
    /// However, this is the type that other services will want as a dependency. So you will probably want to use the service definition interface type.
    /// Note: The service type parameter is invariant (not 'out' nor 'in') because the Microsoft service provider does not have variance. (Meaning that service descriptor for type TBase will *not* provide an instance if TDerived : TBase is requested.)
    /// </typeparam>
    [UtilityTypeMarker]
    public interface IServiceAction<TService> : IServiceAction
    {   
    }


    [UtilityTypeMarker]
    public interface IServiceAction
    {
        /// <summary>
        /// Note: the run method is non-asynchronous. This means that all asynchronous work should be done by the time a service action modifies a service collection.
        /// </summary>
        /// <param name="services"></param>
        void Run(IServiceCollection services);
    }
}
