using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Model
{
    internal class CarDetailsModel: BaseModel
    {
        public string ModelName { get; set; }

        public string ManufacturerName { get; set; }

        public string VIN { get; set; }

        public Transmission Transmission { get; set; }

        public int Year { get; set; }

        public FuelTypes FuelType { get; set; }

        public CarColors Color { get; set; }

        public decimal Price { get; set; }

        public CarCondition Condition { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public byte[] Picture { get; set; }
    }
}
