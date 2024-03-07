using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Entities
{
    public class Machine : EntityBase
    {
        public string? Manufacturer { get; set; }

        public int? YearOfManufacture { get; set; }

        public override string ToString() => $"ID: {Id}, Name: {Name}, Manufacturer: {Manufacturer}, Years of Manufacture : {YearOfManufacture} ";
    }
}
