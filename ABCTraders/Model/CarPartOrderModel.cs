using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Model
{
    internal class CarPartOrderModel
    {
        public int Id { get; set; }
        
        public int CustomerId { get; set; }
        public string PartName { get; set; }
        public string FristName { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Conditon { get; set; }
        public int Status { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string OrderedDate { get; set; }

        public string ApprovedDate { get; set; }

        public string DeliveredDate { get; set; }
    }
}
