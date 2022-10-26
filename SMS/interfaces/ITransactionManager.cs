using System.Transactions;

namespace SMS.interfaces
{
    public interface ITransactionManager
    {
       void CreateTransaction(List<string> barCode, List<int> quantity, string customerId, double cashTender);
        // void GetTransaction(string receiptNo);
        // Transaction UpdateTransaction();
        // void DeleteTransaction(string receiptNo);
        void GetAllTransactions();
        double GetAllTransactionsAdmin();
        double CalculateTotalSales();
        

    }
}