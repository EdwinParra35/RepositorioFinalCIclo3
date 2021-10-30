using System.Net.Security;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MovieProject.Client.Services;

namespace MovieProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }
        /* Metodo que nos permite configurar el sistemas de inyeccion de dependencias*/
        private static void ConfigureServices(IServiceCollection services){
            services.AddScoped<IServiceMovie, ServiceMovie>();
            services.AddScoped<IServiceActor, ServiceActor>();
            services.AddScoped<IErrorMessage,ErrorMessage>();
        }
    }
}
