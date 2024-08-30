using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Model
{
    internal class Car: BaseModel
    {     
        public string VIN { get; set; }
        public int Transmission { get; set; }
        public int Year { get; set; }
        public FuelTypes FuelType { get; set; }
        public int Color { get; set; }
        public decimal Price { get; set; }
        public CarCondition Condition { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public CarStatus Satuts { get; set; }
        public int ModelId { get; set; }
        public int ManufacturerId { get; set; }

    }
}
