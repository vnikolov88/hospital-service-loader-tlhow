using Common.TLHOW.Models;
using Common.TLHOW.Services;
using Flurl.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalService.Loader.TLHOW
{
    public class Worker : BackgroundService
    {
        private readonly IStorageService _storageService;
        private readonly TimeSpan LoadInterval = TimeSpan.FromMinutes(60);
        private readonly ILogger<Worker> _logger;
        private readonly StartupOptions _options;

        public Worker(
            IOptions<StartupOptions> options,
            ILogger<Worker> logger)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _storageService = new RedisStorageService(_options.RedisConnectionInfo);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                try
                {
                    var tlhowData = await _options.DataExportUrl.GetJsonAsync<TLHOWData>();
                    foreach(var record in tlhowData.ClinicGroup)
                    {
                        await _storageService.UpdateCompanyAsync(record.Value, stoppingToken);
                    }
                }
                catch(Exception ex)
                {
                    _logger.LogError("Error pulling data from TLHOW {error}", ex);
                }
                await Task.Delay(LoadInterval, stoppingToken);
            }
        }
    }
}
