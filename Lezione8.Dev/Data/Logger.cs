using System.Runtime.CompilerServices;

namespace Lezione8.Dev.Data
{
    public class Logger
    {
        private readonly ILogger<Logger> _logger;

        public DateTime LogTime { get; set; } = DateTime.Now;

        public Logger(ILogger<Logger> logger)
        {
            _logger = logger;
            _logger.LogInformation($"Logger initialized at {LogTime.ToLongTimeString()}");
        }
    }
}
