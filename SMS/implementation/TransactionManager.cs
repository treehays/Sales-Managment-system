using System.Transactions;
using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class TransactionManager : ITransactionManager
    {
        public static List<Transactiona> listOfTransaction = new List<Transactiona>();
        // public static List<Transactiona> listOfCart = new List<Transactiona>();
        IProductManager iProductManager = new ProductManager();
        public void CreateTransaction(List<string> barCode, List<int> quantity, string customerId, double cashTender)
        {
            var products = iProductManager.GetSelectedProducts(barCode);
            int id = listOfTransaction.Count() + 1;
            string receiptNo = "ref" + new Random(id).Next(2323, 1000000).ToString();

            double total = 0;
            //product.Price * quantity;
            for (int i = 0; i < products.Count; i++)
            {
                total += products[i].Price * quantity[i];
            }
            double xpectedChange = cashTender - total;
            DateTime dateTime = DateTime.Now;
            if (xpectedChange < 0)
            {
                Console.WriteLine($"You can't pay lower than {total}");
            }
            else
            {
                Transactiona transaction = new Transactiona(id, receiptNo, barCode, quantity, total, customerId, dateTime, cashTender);
                listOfTransaction.Add(transaction);
                System.Console.WriteLine("Barcode: ");
                products.ForEach(x => System.Console.WriteLine(x.ProductName + " "+ x.Price));
                Console.WriteLine($"Transaction Date: {dateTime} \tReceipt No: {receiptNo} \nQuantity:{quantity.Count} \nTotal: {total}\nCustomer ID:{customerId}.\nCustomer Change: {xpectedChange}");
            }

        }
        public double CalculateTotalSales()
        {
            double totalSales = 0;
            foreach (var item in listOfTransaction)
            {
                totalSales = item.Total + totalSales;
            }
            return totalSales;
        }
        public void GetAllTransactions()
        {
            Console.WriteLine("\nID\t\tTRANS. DATE \tCUSTOMER NAME\tTOTAL AMOUNT\tBARCODE\tRECEIPT NO");

            foreach (var item in listOfTransaction)
            {
                Console.WriteLine($"{item.Id}\t{item.Datetime.ToString("d")}\t{item.CustomerId}\t{item.BarCode}\t{item.ReceiptNo}\t{item.Quantity}\t{item.Total}");
            }
        }

        public double GetAllTransactionsAdmin()
        {
            double cumulativeSum = 0;
            foreach (var item in listOfTransaction)
            {
                Console.WriteLine($"{item.Id}\t{item.Datetime.ToString("d")}\t{item.CustomerId}\t{item.BarCode}\t{item.ReceiptNo}\t{item.Quantity}\t{item.Total}\t{cumulativeSum += item.Total}");
            }
            return cumulativeSum;
        }
        // public void GetTransaction(String barCode)
        // {
        // }
    }
}