using System.Transactions;

namespace SMS.interfaces
{
    public interface ITransactionManager
    {
        public void CreateTransaction(int id);
        public void GetTransaction(int receiptNo);
        // public Transaction UpdateTransaction();
        public void DeleteTransaction(int receiptNo);
    }
}