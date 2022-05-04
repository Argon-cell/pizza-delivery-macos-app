using System;
namespace pizzaDeliveryApp.Models

{
    public class Orders
    {
        public int Id { get; set; }
        public string NameProducts { get; set; }
        public string Adress { get; set; }
        public int NumberPhone { get; set; }
        public int NumberCard { get; set; }
        public DateTime DateCard { get; set; }
        public int CvcCode { get; set; }
        public int Amount { get; set; }

        public Orders()
        {
        }
    }
}

