using System.Transactions;
using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class TransactionManager : ITransactionManager
    {
        public static List<Transaction> listOfTransaction = new List<Transaction>();

        public void CreateTransaction(string customerId, string barCode, int quantity, string customerId)
        {

            int id = listOfTransaction.Count() + 1;
            string receiptNo = new Random(id).Next(1100000).ToString();

            Transaction transaction = new Transaction(receiptNo, barCode, quantity, customerId);
            listOfTransaction.Add(transaction);
            Console.WriteLine($"\nKeep it Safe.\n");

        }

        public void DeleteTransaction(int receiptNo)
        {
            throw new NotImplementedException();
        }

        public void GetAllTransactions(int receiptNo)
        {
            throw new NotImplementedException();
        }

        public void GetTransaction(int receiptNo)
        {
            throw new NotImplementedException();
        }
    }
}