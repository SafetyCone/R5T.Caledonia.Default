using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Caledonia.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultCommandLineInvocationOperator"/> implementation of <see cref="ICommandLineInvocationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultCommandLineInvocationOperator(this IServiceCollection services)
        {
            services.AddSingleton<ICommandLineInvocationOperator, DefaultCommandLineInvocationOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultCommandLineInvocationOperator"/> implementation of <see cref="ICommandLineInvocationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ICommandLineInvocationOperator> AddDefaultCommandLineInvocationOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICommandLineInvocationOperator>(() => services.AddDefaultCommandLineInvocationOperator());
            return serviceAction;
        }
    }
}
