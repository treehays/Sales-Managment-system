namespace SMS.model
{
    public class Product
    {
        public int Id { get; set; }
        public string BarCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int ProductQuantity{get;set;}
        public Product(int id, string barCode, string productName, double price, int productQuantity)
        {
            Id = id;
            BarCode = barCode;
            ProductName = productName;
            Price = price;
            ProductQuantity=productQuantity;

        }
    }
}