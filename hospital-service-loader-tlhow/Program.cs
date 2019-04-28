using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HospitalService.Loader.TLHOW
{
    public class StartupOptions
    {
        public string DataExportUrl { get; set; }
        public string RedisConnectionInfo { get; set; }
    }

    public class Program
    {
        public IConfiguration Configuration { get; }
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostBuilder, services) =>
                {
                    services.Configure<StartupOptions>(hostBuilder.Configuration);
                    services.AddOptions<StartupOptions>("StartupOptions");
                    services.AddHostedService<Worker>();
                });
    }
}
