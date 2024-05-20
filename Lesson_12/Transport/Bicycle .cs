using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Bicycle : Transport
    {
        public string BicycleType { get; set; }

        public Bicycle(string name, int maxSpeed, string bicycleType)
            : base(name, maxSpeed)
        {
            BicycleType = bicycleType;
        }

        public override string Move()
        {
            return $"{Name} ({BicycleType}) is moving at {MaxSpeed} km/h.";
        }
    }
}
