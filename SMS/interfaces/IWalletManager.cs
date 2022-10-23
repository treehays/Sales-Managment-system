namespace SMS.interfaces
{
    public interface IWalletManager
    {
        public void CreateWallet();
        public void GetTotalWalletTransaction();
        public double CalculateRemainingBalance(); 
    }
}