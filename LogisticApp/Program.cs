using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LogisticApp
{
    public class Program
    {
        public static void main(string[] args)
        {
            WebApplication.CreateBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(String[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}