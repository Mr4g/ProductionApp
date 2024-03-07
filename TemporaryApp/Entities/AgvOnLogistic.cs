using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Entities
{
    public class AgvOnLogistic : Machine
    {
        public int? Speed { get; set; }

        public char? Size { get; set; }

        public override string ToString() => base.ToString() + $"Size: {Size}, Speed: {Speed}";
    }
}
