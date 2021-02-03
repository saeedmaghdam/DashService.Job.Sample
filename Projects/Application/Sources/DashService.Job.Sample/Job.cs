using DashService.Logger;
using System.Threading;
using System.Threading.Tasks;
using DashService.Job.Abstraction;

namespace DashService.Job.Sample
{
    public class Job : JobBase, IJob
    {
        private readonly ILogger _logger;

        public virtual string Name => "Sample Job";
        public virtual string Description => "Test Job";
        public virtual string Version => "1.0.0";

        public Job(ILogger logger) : base(logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Hello, I'm the sample job!");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Thank you, bye.");
            return Task.CompletedTask;
        }
    }
}
