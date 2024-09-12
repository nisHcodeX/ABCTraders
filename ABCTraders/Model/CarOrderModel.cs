using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Model
{
    internal class CarOrderModel
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public byte[] Picture { get; set; } 

        public int CustomerId { get; set; }

        public string ManufacturerName { get; set; }

        public string ModelName { get; set; }

        public string FristName { get; set; }

        public string VIN { get; set; }

        public decimal Price { get; set; }

        public int Conditon { get; set; }
        public int Status { get; set; }

        public string Email {  get; set; }  

        public string Description { get; set; }

        public string  OrderedDate { get; set; }

        public string ApprovedDate { get; set; }

        public string DeliveredDate { get; set; }
    }
}
