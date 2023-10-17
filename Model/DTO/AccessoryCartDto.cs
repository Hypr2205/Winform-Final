namespace Final.Model.DTO {
    public class AccessoryCartDto {
        private static int counter = 0;

        public int OrderID { get; private set; }

        public string AccessoryID { get; set; }

        public string AccessoryName { get; set; }

        public decimal SellPrice { get; set; }

        public int Sale { get; set; }

        public string BrandName { get; set; }

        public string CategoryName { get; set; }

        public decimal BuyPrice { get; set; }

        public int BuyQuantity { get; set; }

        public AccessoryCartDto() {
            OrderID = counter + 1;
        }
    }
}
