namespace SMS.model
{
    public class Product
    {
        public int Id { get; set; }
        public double BarCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Product(int id, double barCode, string productName, double price)
        {
            Id = id;
            BarCode = barCode;
            ProductName = productName;
            Price = price;
        }
    }
}