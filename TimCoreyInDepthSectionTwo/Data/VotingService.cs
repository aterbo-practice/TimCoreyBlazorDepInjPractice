using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimCoreyInDepthSectionTwo.Data
{
    public class VotingService : IVotingService
    {
        private readonly ILogger<VotingService> logger;

        public int YesValue { get; private set; }

        public int NoValue { get; private set; }

        public void YesVote()
        {
            YesValue++;
            logger.LogInformation("YesValue incremented to: {YesValue}", YesValue);
        }

        public void NoVote()
        {
            NoValue++;
            logger.LogInformation("NoValue incremented to: {NoValue}", NoValue);
        }

        public VotingService(ILogger<VotingService> logger)
        {
            this.logger = logger;
        }
    }
}
