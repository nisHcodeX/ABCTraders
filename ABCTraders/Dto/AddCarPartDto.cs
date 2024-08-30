using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Dto
{
    internal class AddCarPartDto
    {
        public string PartName { get; set; }

        public string Manufacturer { get; set; }

        public string PartCode { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        public byte[] ImagePath { get; set; }

        public int Condition { get; set; }
    }
}
