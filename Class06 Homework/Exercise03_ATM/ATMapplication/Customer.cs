namespace ATMapplication
{
    public class Customer
    {
        public string FullName { get; set; }
        public long CardNumber  { get; set; }
        private int Pin { get; set; }
        private decimal Balance { get; set; }

        public Customer(string fullName, long cardNumber, int pin, decimal initialBalance = 0) 
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = initialBalance;
        }

        public bool Authenticate(int pinInput)
        {
            return Pin == pinInput;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
