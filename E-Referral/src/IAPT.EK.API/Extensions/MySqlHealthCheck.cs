﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MySql.Data.MySqlClient;

namespace IAPT.EK.API.Extensions
{
    public class MySqlHealthCheck : IHealthCheck
    {
        private readonly string _connection;

        public MySqlHealthCheck(string connection)
        {
            _connection = connection;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                using (var connection = new MySqlConnection(_connection))
                {
                    await connection.OpenAsync(cancellationToken);

                    var command = connection.CreateCommand();
                    command.CommandText = "select count(*) from cities";

                    return Convert.ToInt32(await command.ExecuteScalarAsync(cancellationToken)) > 0 ? HealthCheckResult.Healthy() : HealthCheckResult.Unhealthy();
                }
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy();
            }
          
        }
    }
}
