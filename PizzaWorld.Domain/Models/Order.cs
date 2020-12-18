using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
   public class Order
    {
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();
        
        public List<APizzaModel> Pizzas { get; set; }

        public void MakeMeatPizza()
        {
            Pizzas.Add(_pizzaFactory.Make<MakeMeatPizza>());
        }
    }
}