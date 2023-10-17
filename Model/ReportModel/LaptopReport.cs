namespace Final.Model.ReportModel {
    public class LaptopReport {
        public int OrderID { get; set; }
        public string LaptopID { get; set; }
        public string LaptopName { get; set; }
        public decimal SellPrice { get; set; }
        public int Sale { get; set; }
        public string CategoryName { get; set; }
        public decimal BuyPrice { get; set; }
        public int BuyQuantity { get; set; }
    }
}
