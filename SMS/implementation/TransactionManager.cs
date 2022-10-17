using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class TransactionManager : ITransactionManager
    {
        public void CreateTransaction(string customerName, string orderDate, int quantity)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(int receiptNo)
        {
            throw new NotImplementedException();
        }

        public void GetTransaction(int receiptNo)
        {
            throw new NotImplementedException();
        }
    }
}