  
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class MeatPizza : APizzaModel
  {

  protected override void AddPrice()
  {
    Price = 30.00M;
  }
  protected override void AddName()
  {
    Name = "MeatPizza";
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
