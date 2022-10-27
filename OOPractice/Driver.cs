using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Driver
    {
        public VechileBase vechile;

        public Driver(VechileBase vechile)
        {
            this.vechile = vechile;
        }

        public string Drive()
        {
            return vechile.SpeedUp();
        }
    }
}
