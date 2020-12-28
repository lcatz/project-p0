  
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class VeggiePizza : APizzaModel
  {
  
  
  protected override void AddPrice()
  {
    Price = 20.00M;
  }
  protected override void AddName()
  {
    Name = "VeggiePizza";
  }

  protected override void AddCrust()
    {
      Crust = "regular";
    }

    protected override void AddSize()
    {
      Size = "small";
    }

    protected override void AddToppings()
    {
            
    }

    public override string ToString()
        {
          return $"{Name}";
        }
  }

}
