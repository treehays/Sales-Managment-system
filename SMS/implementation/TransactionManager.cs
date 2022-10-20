using System.Transactions;
using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class TransactionManager : ITransactionManager
    {
        public static List<Transactiona> listOfTransaction = new List<Transactiona>();
        IProductManager iProductManager = new ProductManager();
        public void CreateTransaction(String ReceiptNo, string barCode, int quantity, string customerId, double cashTender)
        {
            var product = iProductManager.GetProduct(barCode);
            int id = listOfTransaction.Count() + 1;
            string receiptNo = "ref" + new Random(id).Next(2323, 1000000).ToString();
            double total = product.Price * quantity;
            double xpectedChange = cashTender - total;
            DateTime dateTime = DateTime.Now;
            Transactiona transaction = new Transactiona(id, receiptNo, barCode, quantity, total, customerId, dateTime, cashTender);
            listOfTransaction.Add(transaction);
            Console.WriteLine($"Transaction Date: {dateTime} \tReceipt No: {ReceiptNo} \nBarcode: {product.BarCode} \nPrice Per Unit: {product.Price} \nQuantity:{quantity} \nTotal: {product.Price * quantity}\nCustomer ID:{customerId}.\nCustomer Change: {xpectedChange}");
        }
        public void GetAllTransactions()
        {
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