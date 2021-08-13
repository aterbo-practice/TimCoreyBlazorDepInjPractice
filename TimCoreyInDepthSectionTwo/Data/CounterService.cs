using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimCoreyInDepthSectionTwo.Data
{
    public class CounterService : ICounterService
    {
        private readonly ILogger<CounterService> logger;

        public int CounterValue { get; private set; }

        public void IncreaseCounter()
        {
            CounterValue++;
            logger.LogInformation("Counter Incremented to: {CounterValue}", CounterValue);
        }

        public CounterService(ILogger<CounterService> logger)
        {
            this.logger = logger;
        }
    }
}
