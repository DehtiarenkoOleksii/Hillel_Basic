using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Transport
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        public Transport(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public virtual string Move()
        {
            return $"{Name} is moving at {MaxSpeed} km/h.";
        }
    }
}
