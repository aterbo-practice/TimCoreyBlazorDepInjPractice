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

        public DummyDumbDataAccess()
        {
            Random random = new Random();
            dumbDataInt = random.Next(74);
            dumbDataString = random.Next(10).ToString();
        }

        public int getDumbInt()
        {
            return dumbDataInt;
        }

        public string getDumbString()
        {
            return dumbDataString;
        }
    }
}
