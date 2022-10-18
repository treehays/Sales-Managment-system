using SMS.interfaces;
using SMS.model;

namespace SMS.implementation
{
    public class ProductManager : IProductManager
    {
        public static List<Product> listOfProduct = new List<Product>();

        public void CreateProduct(double barCode, string productName, double price)
        {
            int id = listOfProduct.Count() + 1;
            Product product = new Product(id, barCode, productName, price);
            listOfProduct.Add(product);
            Console.WriteLine($"Product Added Successfully. \nThere are total of {id} in the store.");

        }

        public void DeleteProduct(int barCode)
        {
            Product product = GetProduct(barCode);
            if (product != null)
            {
                Console.WriteLine($"{product.ProductName} Successfully deleted. ");
                listOfProduct.Remove(product);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public Product GetProduct(int barCode)
        {
            foreach (var item in listOfProduct)
            {
                if (item.BarCode == barCode)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateProduct(int barCode, string productName, double price)
        {
            Product product = GetProduct(barCode);
            if (product != null)
            {
                product.BarCode = barCode;
                product.ProductName = productName;
                product.Price = price;
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}