using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class ProductManager : IProductManager
    {
        public static List<Product> listOfProduct = new List<Product>();
        public void CreateProduct(string barCode, string productName, double price, int productQuantity)
        {
            int id = listOfProduct.Count() + 1;
            Product product = new Product(id, barCode, productName, price, productQuantity);
            if (GetProduct(barCode) == null)
            {
                listOfProduct.Add(product);
                Console.WriteLine($"Product Added Successfully. \nThere are total of {id} product's in the store.");
            }
            else
            {
                Console.WriteLine("Product already exist. \nKindly Go to Update to Update Available Quantity");
            }
        }
        public void DeleteProduct(string barCode)
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

        public Product GetProduct(string barCode)
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

        public List<Product> GetSelectedProducts(List<string> barCodes)
        {
            return listOfProduct.Where(x => barCodes.Contains(x.BarCode)).ToList();
            // for (var i = 0; i < listOfProduct.Count; i++)
            // {

            //     if (listOfProduct.Contains(barCodes[i]) )
            //     {
            //         yield return listOfProduct[i];
            //     }
            // }
            // yield return null;

        }

        public void UpdateProduct(string barCode, string productName, double price)
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
        public void ViewAllProduct()
        {
            foreach (var item in listOfProduct)
            {
                Console.WriteLine($"{item.Id}\t{item.ProductName}\t{item.BarCode}\t{item.Price}\t{item.ProductQuantity}");
            }
        }
    }
}