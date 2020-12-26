
using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {
    public string Crust { get; set; }
    public string Size { get; set; }
  

    protected APizzaModel()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected virtual void AddCrust() { }
    protected virtual void AddSize() { }
    protected virtual void AddToppings() { }
  }
}