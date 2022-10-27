using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Truck : VechileBase
    {
        public Truck(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }
    }
}
