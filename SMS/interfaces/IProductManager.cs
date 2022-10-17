using SMS.model;

namespace SMS.interfaces
{
    public interface IProductManager
    {
        public void CreateProduct(double barCode, string productName, double price);
        public Product GetProduct(int barCode);
        public void UpdateProduct(int barCode, string productName, double price);
        public void DeleteProduct(int barCode);
    }
}