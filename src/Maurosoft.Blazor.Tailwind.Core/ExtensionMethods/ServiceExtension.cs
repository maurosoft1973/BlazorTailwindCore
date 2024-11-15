using Maurosoft.Blazor.Tailwind.Components.Common;
using Maurosoft.Blazor.Tailwind.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;

public static class ServiceExtension
{
    public static IServiceCollection AddBlazorTailwindCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<IGeneratorId, GeneratorId>();
        return services;
    }
}
