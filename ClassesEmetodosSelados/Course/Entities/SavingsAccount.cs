namespace Course.Entities
{
    sealed class SavingsAccount : Account  /* Método selado, não posso herdar outro método */
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        */
        public sealed override void Withdraw(double amount) //Mesma coisa no método, porém so funciona em métodos sobrescritos
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }

}
