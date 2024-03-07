using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Entities
{
    public class Printer : Machine
    {
        public string? KindOfLabel { get; set; }

        public override string ToString() => base.ToString() + $"KindOfLabel: {KindOfLabel}";
    }
}
