using HospitalService.Loader.TLHOW.Models;
using Flurl.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Consul;

namespace HospitalService.Loader.TLHOW
{
    public class Worker : BackgroundService
    {
        private readonly TimeSpan loadInterval;
        private readonly ILogger<Worker> _logger;
        private readonly StartupOptions _options;
        private readonly IMapper _mapper;

        public Worker(
            IOptions<StartupOptions> options,
            ILogger<Worker> logger,
            IMapper mapper)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            loadInterval = TimeSpan.FromMinutes(_options.DataExportPullIntervalMin);
        }

        protected async Task<string> GetServiceHostAsync(string serviceName)
        {
            using (var consul = new ConsulClient(x => x.Address = new Uri(_options.ConsulRestUrl)))
            {
                var consulResponse = await consul.Catalog.Service(serviceName);
                var catalogServices = consulResponse.Response;
                if (catalogServices.Count() > 0)
                    return catalogServices.Select(x => $"{x.ServiceAddress}:{x.ServicePort}").FirstOrDefault();
                else
                    throw new ConsulRequestException($"Missing {serviceName}", consulResponse.StatusCode);
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                try
                {
                    var tlhowData = await _options.DataExportUrl.GetJsonAsync<TLHOWData>();
                    var hospitalServiceHost = await GetServiceHostAsync(_options.HospitalServiceName);
                    foreach (var record in tlhowData.ClinicGroup)
                    {
                        var internalHospitalData = _mapper.Map<Contracts.V2.Company>(record.Value);
                        await $"http://{hospitalServiceHost}/api/v2/hospital/update-company"
                            .PostJsonAsync(internalHospitalData, stoppingToken);
                    }
                }
                catch(Exception ex)
                {
                    _logger.LogError("Error pulling data from TLHOW {error}", ex);
                }
                await Task.Delay(loadInterval, stoppingToken);
            }
        }
    }
}
