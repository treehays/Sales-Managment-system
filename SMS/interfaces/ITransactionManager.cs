using System.Transactions;

namespace SMS.interfaces
{
    public interface ITransactionManager
    {
        public void CreateTransaction(string receiptNo, string barCode, int quantity, string customerId);
        public void GetTransaction(string receiptNo);
        // public Transaction UpdateTransaction();
        // public void DeleteTransaction(string receiptNo);
        public void GetAllTransactions(string receiptNo);
    }
}