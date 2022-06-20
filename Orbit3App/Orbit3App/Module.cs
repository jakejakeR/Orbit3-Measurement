using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbit3App
{
    internal class Module
    {
        public String Name { get; set; }
        public double[] Reads { get; set; }
        private int CollectionSize;

        public Module(int CollectionSize)
        {
            this.CollectionSize = CollectionSize;
            Reads = new double[CollectionSize];
        }
    }
}
