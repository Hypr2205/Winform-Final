namespace Final.Model.DTO {
    public class LaptopCartDto {
        private static int counter = 0;
        public int OrderId { get; set; } = counter + 1;
        public string LaptopId { get; set; }
        public string LaptopName { get; set; }
        public decimal SellPrice { get; set; }
        public int Sale { get; set; }
        public string BrandName { get; set; }
        public decimal BuyPrice { get; set; }
        public int BuyQuantity { get; set; }
    }
}
