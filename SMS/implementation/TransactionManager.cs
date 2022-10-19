using System.Transactions;
using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class TransactionManager : ITransactionManager
    {
        public static List<Transactiona> listOfTransaction = new List<Transactiona>();
        // public static List<Transactiona> listOfCustomerCart = new List<Transactiona>();
        IProductManager iProductManager = new ProductManager();
        public void CreateTransaction(String ReceiptNo, string barCode, int quantity, string customerId)
        {
            var product = iProductManager.GetProduct(barCode);

            int id = listOfTransaction.Count() + 1;
            string receiptNo = new Random(id).Next(2323,110000).ToString();
            double total = product.Price * quantity;


            Transactiona transaction = new Transactiona(id, receiptNo, barCode, quantity, total, customerId);
            listOfTransaction.Add(transaction);


            Console.WriteLine($"\nReciept No: {ReceiptNo} \nBarcode: {product.BarCode} \nPrice Per Unit: {product.Price} \nQuantity:{quantity} \nTotal: {product.Price * quantity}\nCustomer ID:{customerId}.\n");

        }

        // public void DeleteTransaction(String receiptNo)
        // {
        //     throw new NotImplementedException();
        // }

        public void GetAllTransactions(String receiptNo)
        {
            // throw new NotImplementedException();
            foreach (var item in listOfTransaction)
            {
                Console.WriteLine($"Staff Id: {item.Id} {item.CustomerId} {item.BarCode} {item.ReceiptNo} ");
            }
        }

        public void GetTransaction(String barCode)
        {
            // ProductManager productManager = new ProductManager();
            // productManager.GetProduct(barCode);
            // if (productManager != null)
            // {
            //     // Console.WriteLine($"S. ");
            //     listOfCustomerCart.Add(productManager);

            // }
            // else
            // {
            //     Console.WriteLine("Product not found.");
            // }
        }
    }
}