using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Hosting;


namespace R5T.L0016.X001
{
    public static class IWebHostBuilderExtensions
    {
        /// <summary>
        /// Adds only the basics required to get an ASP.NET Core web application running.
        /// * Kestrel,
        /// * Routing
        /// * IIS
        /// </summary>
        /// <remarks>
        /// Adapted from:
        /// * (newer): https://github.com/dotnet/aspnetcore/blob/3d8215e57c8c874449b33c982ebf6a7889dc740b/src/DefaultBuilder/src/WebHost.cs#L215
        /// * (older): https://github.com/aspnet/MetaPackages/blob/d417aacd7c0eff202f7860fe1e686aa5beeedad7/src/Microsoft.AspNetCore/WebHost.cs#L201
        /// </remarks>
        public static TWebHostBuilder ConfigureBasics<TWebHostBuilder>(this TWebHostBuilder webHostBuilder)
            where TWebHostBuilder : IWebHostBuilder
        {
            webHostBuilder
                .UseKestrel()
                .ConfigureServices(services =>
                {
                    services.AddRouting();
                })
                .UseIIS()
                .UseIISIntegration()
                ;

            return webHostBuilder;
        }
    }
}