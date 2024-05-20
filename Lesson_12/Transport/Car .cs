using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Car : Transport
    {
        public int NumberOfDoors { get; set; }

        public Car(string name, int maxSpeed, int numberOfDoors)
            : base(name, maxSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string Move()
        {
            return $"{Name} with {NumberOfDoors} doors is moving at {MaxSpeed} km/h.";
        }
    }
}
