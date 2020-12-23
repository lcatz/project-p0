  
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class Order : AEntity
  {
    private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

    public List<APizzaModel> Pizzas { get; set; }

    public Order()
    {
      Pizzas = new List<APizzaModel>();
    }

    public void MakeMeatPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
    }
  }
}