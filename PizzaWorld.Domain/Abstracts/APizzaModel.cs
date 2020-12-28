
using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {
    public string Crust { get; set; }
    public string Size { get; set; } 

    public string Name { get; set; }

    public decimal Price { get; set; }

    protected APizzaModel()
    {
      AddName();
      AddCrust();
      AddSize();
      AddToppings();
      AddPrice();
    }

    protected virtual void AddCrust() { }
    protected virtual void AddName() { }
    protected virtual void AddSize() { }
    protected virtual void AddToppings() { }

    protected virtual void AddPrice() { }
  }
}