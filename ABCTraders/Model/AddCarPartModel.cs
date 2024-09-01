using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Model
{
    internal class AddCarPartModel: BaseModel
    {
        public string PartName { get; set; }
        public int ManufacturerId { get; set; }
        public string PartCode { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }  
        public CarCondition Condition { get; set; }
        public string Description { get; set; }
        public byte[] ImagePath { get; set; }
    }
}
