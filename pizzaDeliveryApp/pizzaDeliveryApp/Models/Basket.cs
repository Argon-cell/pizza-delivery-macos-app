namespace pizzaDeliveryApp.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int CountProduct { get; set; }
        public int Amount { get; set; }

        public Basket()
        {
        }
    }
}
