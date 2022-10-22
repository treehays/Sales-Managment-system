using System.Transactions;

namespace SMS.interfaces
{
    public interface ITransactionManager
    {
        public void CreateTransaction(string barCode, int quantity, string customerId, double cashTender);
        public void GetAllTransactions();
        public double CalculateTotalSales();
    }
}