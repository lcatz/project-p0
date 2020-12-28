  
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class Order : AEntity
  {
    private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

    public List<APizzaModel> Pizzas { get; set; }

    public decimal OrderPrice { get; set; } = 0.0M;
  

    public Order()
    {
      Pizzas = new List<APizzaModel>();
    }

    public void MakeMeatPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
      OrderPrice += 30.00M;
    }
   public void MakeVeggiePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
      OrderPrice += 20.00M;
    }

    public void MakeHawaiianPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<HawaiianPizza>());
      OrderPrice += 10.00M;
    }

    public void RemoveHawaiianPizza()
    {
      int x = 0;
      while(x == 0)
      {
        foreach (APizzaModel pizza in Pizzas) {
          if (pizza.Name == "HawaiianPizza") {
            Pizzas.Remove(pizza);
            x = 1;
        break;
  }
      }
      OrderPrice -= 10.00M;
    }
    }

    public void RemoveMeatPizza()
    {
     int x = 0;
      while(x == 0)
      {
        foreach (APizzaModel pizza in Pizzas) {
          if (pizza.Name == "MeatPizza") {
            Pizzas.Remove(pizza);
            x = 1;
        break;
  }
      }
      OrderPrice -= 10.00M;
    } 
     OrderPrice -= 30.00M;
    }

    public void RemoveVeggiePizza()
    {
      int x = 0;
      while(x == 0)
      {
        foreach (APizzaModel pizza in Pizzas) {
          if (pizza.Name == "VeggiePizza") {
            Pizzas.Remove(pizza);
            x = 1;
        break;
  }
      }
      OrderPrice -= 10.00M;
    }
      OrderPrice -= 20.00M;
    }

        public override string ToString()
        {
            return $"\nYour Order Total Is: ${OrderPrice}\n";
        }
  
  }
}