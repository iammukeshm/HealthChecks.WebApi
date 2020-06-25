using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthChecks.WebApi.HealthChecks
{
public class CustomHealthCheck : IHealthCheck
{
	public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
	{
		try
		{
			throw new Exception("Random Error Caught!");
		}
		catch (Exception ex)
		{

			return Task.FromResult(HealthCheckResult.Unhealthy(ex.Message));
		}
	}
}
}
