using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimCoreyInDepthSectionTwo.Data
{
    public class InjectedDataService
    {
        private readonly IDataAccessSingleton dataAccessSingleton;
        private readonly IDataAccessScoped dataAccessScoped;
        private readonly IDataAccessTransient dataAccessTransient;

        public InjectedDataService(IDataAccessSingleton dataAccessSingleton,
                                   IDataAccessScoped dataAccessScoped,
                                   IDataAccessTransient dataAccessTransient)
        {
            this.dataAccessSingleton = dataAccessSingleton;
            this.dataAccessScoped = dataAccessScoped;
            this.dataAccessTransient = dataAccessTransient;
        }

        public Task<InjectedData> GetInjectedDataClass()
        {
            return Task.FromResult(new InjectedData(dataAccessSingleton.getDumbInt(),
                                                    dataAccessScoped.getDumbInt(),
                                                    dataAccessTransient.getDumbInt()));
        }
    }
}
