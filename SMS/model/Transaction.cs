namespace SMS.model
{
    public class Transaction
    {
        public string ReceiptNo { get; set; }
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int Quantity { get; set; }
        public int BarCode { get; set; }
        public Transaction(int id, string receiptNo, string barCode, int quantity, string customerId)
        {
            ReceiptNo = receiptNo;
            Id = id;
            BarCode = barCode;
            Quantity = quantity;
            CustomerId =customerId;
        }
    }
}