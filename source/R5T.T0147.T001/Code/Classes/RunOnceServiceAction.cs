using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0147
{
    /// <summary>
    /// A service action implementation that ensures it only run itself once.
    /// </summary>
    public class RunOnceServiceAction<TService> : IServiceAction<TService>
    {
        public Action<IServiceCollection> Action { get; }

        private bool HasRun { get; set; } = false;


        public RunOnceServiceAction(Action<IServiceCollection> action)
        {
            this.Action = action;
        }

        public void Run(IServiceCollection services)
        {
            if (!this.HasRun)
            {
                this.Action(services);

                this.HasRun = true;
            }
        }
    }
}
