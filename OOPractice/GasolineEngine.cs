using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class GasolineEngine : IEngine
    {
        private int speed;
        public GasolineEngine()
        {
            speed = 30;
        }

        public int Speed { get => speed; set => speed = value; }
    }
}
