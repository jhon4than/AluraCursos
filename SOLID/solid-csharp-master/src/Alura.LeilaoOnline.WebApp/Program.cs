using Alura.LeilaoOnline.WebApp.Seeding;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Alura.LeilaoOnline.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Cria Base de dados se n�o houver uma criada, na inicializa��o do projeto.
            DatabaseGenerator.Seed();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
