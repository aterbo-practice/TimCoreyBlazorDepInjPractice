﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimCoreyInDepthSectionTwo.Data
{
    public class CounterService
    {
        private readonly ILogger logger;

        public int CounterValue { get; private set; }

        public void IncreaseCounter()
        {
            CounterValue++;
            logger.LogInformation("Counter Incremented to: {CounterValue}", CounterValue);
        }

        public CounterService(ILogger logger)
        {
            this.logger = logger;
        }
    }
}
