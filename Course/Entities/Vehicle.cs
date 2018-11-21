using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Vehicle
    {
        public Vehicle(string model)
        {
            Model = model;
        }

        public string Model { get; set; }
    }
}
