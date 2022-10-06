using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0147
{
    /// <summary>
    /// A service action that, when run, does nothing.
    /// This is useful in the case where a <see cref="IServiceAction{TService}"/> dependency must be satisified, but the service itself has been added by external code, so it should actually be added again.
    /// </summary>
    public class DoNothingServiceAction<TService> : IServiceAction<TService>
    {
        public void Run(IServiceCollection services)
        {
            // Do nothing.
        }
    }
}
