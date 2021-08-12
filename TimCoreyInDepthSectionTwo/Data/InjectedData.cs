using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimCoreyInDepthSectionTwo.Data
{
    public class InjectedData
    {
        public int InjectedSingletonInt { get; set; }

        public int InjectedScopedInt { get; set; }

        public int InjectedTransientInt { get; set; }

        public InjectedData(int injectedSingletonInt, int injectedScopedInt, int injectedTransientInt)
        {
            InjectedSingletonInt = injectedSingletonInt;
            InjectedScopedInt = injectedScopedInt;
            InjectedTransientInt = injectedTransientInt;
        }
    }
     
}
