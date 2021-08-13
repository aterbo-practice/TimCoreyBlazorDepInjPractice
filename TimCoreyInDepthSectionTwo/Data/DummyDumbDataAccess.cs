using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimCoreyInDepthSectionTwo.Data
{
    public class DummyDumbDataAccess : IDataAccessScoped, IDataAccessSingleton, IDataAccessTransient
    {

        private int dumbDataInt;
        private string dumbDataString;
        private readonly ILogger<DummyDumbDataAccess> logger;
        private readonly IConfiguration config;

        public DummyDumbDataAccess(ILogger<DummyDumbDataAccess> logger, IConfiguration config)
        {
            this.logger = logger;
            this.config = config;
            Random random = new Random();
            dumbDataInt = random.Next(74);
            dumbDataString = random.Next(10).ToString();
            logger.LogWarning("Random number generated: {dumbDataInt}", dumbDataInt);

            dumbDataInt = config.GetValue<int>("NotSoRandomRandomInt");
            logger.LogWarning("dumbDataInt reset to NotSoRandomRandomInt: {dumbDataInt}", dumbDataInt);

        }

        public DummyDumbDataAccess()
        {
            //Random random = new Random();
            //dumbDataInt = random.Next(74);
            //dumbDataString = random.Next(10).ToString();
            //logger.LogWarning("Random number generated: {dumbDataInt}", dumbDataInt);
        }

        public int getDumbInt()
        {
            logger.LogWarning("dumbDataInt number returned: {dumbDataInt}", dumbDataInt);
            return dumbDataInt;
        }

        public string getDumbString()
        {
            return dumbDataString;
        }
    }
}
