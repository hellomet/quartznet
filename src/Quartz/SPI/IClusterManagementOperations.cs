using System;
using System.Threading;
using System.Threading.Tasks;

namespace Quartz.Spi
{
    public interface IClusterManagementOperations
    {
        TimeSpan ClusterCheckinInterval { get; }
        DateTimeOffset LastCheckin { get; }

        Task<bool> CheckCluster(Guid requestorId, CancellationToken cancellationToken = default);
    }
}