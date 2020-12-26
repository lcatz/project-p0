namespace PizzaWorld.Domain.Models
{
    public class Toppings
    {
        public string Cheese { get; set; }
        public string Tomato { get; set; }

        public void  MeatPizza()
        {
            Cheese = "Provolone";
            Tomato = "Medium Spread";
        }

    }
}