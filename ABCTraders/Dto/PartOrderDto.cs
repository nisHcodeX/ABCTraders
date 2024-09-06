using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Dto
{
    internal class PartOrderDto
    {
        public int PartId { get; set; }

        public int CustomerId { get; set; }

        public int Quantity { get; set; }

        public decimal FullPrice { get; set; }

        public int Status { get; set; }
    }
}
