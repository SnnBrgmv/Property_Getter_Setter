namespace Property_Set_Get
{
    public class SimCard
    {
        public string CarrierName { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public decimal Tariff { get; set; }

        public void IncreaseBalance(decimal amount)
        {
            if (amount <= 0) return;
            Balance += amount;
        }
        public void Call()
        {
            if (Tariff > Balance) {
                Console.WriteLine($"Not enough money Balance: {Balance = 0}");
            }
            else
            {
                Balance -= Tariff;
                Console.WriteLine($"Balance: {Balance}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SimCard simCard = new SimCard()
            {
                CarrierName = "Azercell",
                Number = "050-243-00-73",
                Balance = 0.01m,
                Tariff = .05m
            };

            //simCard.IncreaseBalance(.2m);
            simCard.Call();
        }
    }
}