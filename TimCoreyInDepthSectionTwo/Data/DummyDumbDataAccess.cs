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

        public DummyDumbDataAccess(ILogger<DummyDumbDataAccess> logger)
        {
            this.logger = logger;

            Random random = new Random();
            dumbDataInt = random.Next(74);
            dumbDataString = random.Next(10).ToString();
            logger.LogWarning("Random number generated: {dumbDataInt}", dumbDataInt);
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
            logger.LogWarning("Random number returned: {dumbDataInt}", dumbDataInt);
            return dumbDataInt;
        }

        public string getDumbString()
        {
            return dumbDataString;
        }
    }
}
