using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carsRESTprovider.model
{
    public class FilterRecord
    {
        private int _low;
        private int _high;

        public int Low
        {
            get => _low;
            set => _low = value;
        }

        public int High
        {
            get => _high;
            set => _high = value;
        }
    }
}
