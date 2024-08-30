using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Model
{
    internal class AddCarModel: BaseModel
    {
        public string Model { get; set; }           
        public string Manufacturer { get; set; }
        public string VIN { get; set; }
        public string Transmission { get; set; }
        public int Year { get; set; }
        public FuelTypes FuelType { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public CarCondition Condition { get; set; }
        public string Description { get; set; }
        public byte[] ImagePath { get; set; }
        public CarStatus Satuts { get; set; }

    }
}
