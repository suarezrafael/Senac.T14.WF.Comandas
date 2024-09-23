using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Comandas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // Configura o DbContext para usar SQLite
                services.AddDbContext<BancoDeDados>(options =>
                options.UseSqlite("Data Source=comandas.db"));

                // Registre seus Forms aqui
                services.AddTransient<FrmPrincipal>();
                // Adicione outros Forms ou serviços conforme necessário
            })
            .Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var mainForm = services.GetRequiredService<FrmPrincipal>();
                Application.Run(mainForm);
            }
            //Application.Run(new FrmPrincipal());
        }
    }
}