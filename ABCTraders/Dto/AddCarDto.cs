namespace ABCTraders.Dto
{
    internal class AddCarDto
    {
        public string VIN { get; set; }

        public int Transmission { get; set; }

        public int Color { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int FuelType { get; set; }

        public decimal Price { get; set; }

        public byte[] Picture { get; set; }

        public int Condition { get; set; }
        public int ModelId { get; set; }
        public int ManufacturerId { get; set; }
    }
}
