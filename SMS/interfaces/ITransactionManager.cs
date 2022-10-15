namespace SMS.interfaces
{
    public interface ITransactionManager
    {
        public void CreateTransaction(string customerName, string orderDate, int quantity);
        public void GetTransaction(int receiptNo);
        // public void UpdateTransaction();
        public void DeleteTransaction(int receiptNo);
    }
}