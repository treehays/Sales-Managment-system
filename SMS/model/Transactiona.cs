namespace SMS.model
{
    public class Transactiona
    {
        public string ReceiptNo { get; set; }
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public List<int> Quantity { get; set; }
        public double Total { get; set; }
        public List<string> BarCode { get; set; }
        public DateTime Datetime { get; set; }
        public double CashTender { get; set; }
        public Transactiona(int id, string receiptNo, List<string> barCode, List<int> quantity, double total, string customerId, DateTime datetime, double cashTender)
        {
            ReceiptNo = receiptNo;
            Id = id;
            CashTender = cashTender;
            BarCode = barCode;
            Quantity = quantity;
            CustomerId = customerId;
            Total = total;
            Datetime = datetime;
        }
    }
}