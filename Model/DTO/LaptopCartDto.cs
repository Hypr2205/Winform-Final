using System.ComponentModel.DataAnnotations;

namespace Final.Model.DTO {
    public class LaptopCartDto {
            public static int counter = 0;
            public int OrderID { get; set; }
            public string LaptopID { get; set; }
            public string LaptopName { get; set; }
            public decimal SellPrice { get; set; }
            public int Sale { get; set; }
            public int CategoryID { get; set; }
            public int Quantity { get; set; }
            public int BuyPrice { get; set; }   
            public int BuyQuantity { get; set; }   
            public LaptopCartDto() {
                  OrderID += 1;
            }
      }
}
