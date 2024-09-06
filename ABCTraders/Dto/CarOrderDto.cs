using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Dto
{
    internal class CarOrderDto
    {
        public int CarId { get; set; }
        public decimal Price { get; set; }   
        public int CustomerId { get; set; }
        public int Status { get; set; }
    }
}
