using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Dto
{
    internal class AddCarDto
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string VIN { get; set; }

        public string Transmission { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int FuelType { get; set; }

        public decimal Price { get; set; }

        public byte[] ImagePath { get; set; }

        public int Condition { get; set; }
    }
}
