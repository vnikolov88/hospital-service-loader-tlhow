using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;

namespace HospitalService.Loader.TLHOW
{
    public class StartupOptions
    {
        public string DataExportUrl { get; set; }

        public int DataExportPullIntervalMin { get; set; }

        public string HospitalServiceName { get; set; }

        public string ConsulRestUrl { get; set; }
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
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile(new DomainProfile());
                    });

                    var mapper = config.CreateMapper();
                    services.AddSingleton(mapper);
                    services.AddHostedService<Worker>();
                });
    }
}
