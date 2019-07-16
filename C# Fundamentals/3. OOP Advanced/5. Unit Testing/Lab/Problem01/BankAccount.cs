namespace Problem01
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        public decimal Amount { get; private set; }

        public void Deposit(decimal amount)
        {
            this.Amount = amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.Amount - amount >= 0)
            {
                this.Amount -= amount;
            }
        }
    }
}