using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EscuelaMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Inicializa el Web Server
            // CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();
            // Aqui código que se asegura de que está la BD creada antes de iniciar el host
            // Para evitar que quede vivo en memoria, using y así tendra el ciclo de vida dentro de using
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<EscuelaContext>();
                    context.Database.EnsureCreated(); // Asegúerese de que la BD está creada
                }
                catch (Exception e)
                {                
                    // Guardemos en un log el error (No se ve )
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "An error occurred creating the DB.");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
