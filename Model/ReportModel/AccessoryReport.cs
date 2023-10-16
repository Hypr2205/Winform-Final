namespace Final.Model.ReportModel {
    public class AccessoryReport {
        public int OrderID { get; set; }

        public string AccessoryID { get; set; }

        public string AccessoryName { get; set; }

        public decimal SellPrice { get; set; }

        public int Sale { get; set; }

        public string BrandName { get; set; }

        public string CategoryName { get; set; }

        public decimal BuyPrice { get; set; }

        public int BuyQuantity { get; set; }
    }
}
