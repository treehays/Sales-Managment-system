namespace SMS.model
{
    public class Transaction
    {
        public int ReceiptNo { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string OrderDate { get; set; }
        public int Quantity { get; set; }
        public int BarCode { get; set; }
        public DateTime CurrentTime { get; set; }
        public Transaction(int id, int receiptNo, int barCode, string customerName, string orderDate, int quantity, DateTime currentTime)
        {
            ReceiptNo = receiptNo;
            Id = id;
            BarCode = barCode;
            CustomerName = customerName;
            OrderDate = orderDate;
            Quantity = quantity;
            CurrentTime = currentTime;
        }
    }
}