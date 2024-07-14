using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Microservices
{

    public class MyCustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            // Simulate a health check logic here
            bool isHealthy = true; // Replace with actual health check logic

            if (isHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("The check indicates a healthy result."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("The check indicates an unhealthy result."));
        }
    }
}
