using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class ElectricEngine : IEngine
    {
        private int speed;
        public ElectricEngine()
        {
           speed = 25;
        }

        public int Speed { get => speed; set => speed = value; }
    }
}
