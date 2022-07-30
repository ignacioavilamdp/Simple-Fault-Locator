using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLOCATOR
{
    public class LoopResults
    {
        public double DistancePu { get; set; }
        public double FaultResistance { get; set; }

        public LoopResults(double distancePu, double faultResistance)
        {
            DistancePu = distancePu;
            FaultResistance = faultResistance;
        }
    }
}
