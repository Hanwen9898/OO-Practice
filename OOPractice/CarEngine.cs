using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class CarEngine
    {
        private string enginetype;

        public CarEngine(string enginetype)
        {
            this.enginetype = enginetype;
        }

        public int Speed()
        {
            if (enginetype == "gasoline") { return 30; }
            else if (enginetype == "electric") { return 25; }
            else { return 0; }
        }
    }
}
