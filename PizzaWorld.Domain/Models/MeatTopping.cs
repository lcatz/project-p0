  
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class MeatTopping : AToppingModel
  {
  protected override void AddMeat()
    {
      Meat = "Pepperoni";
    }

    protected override void AddVeggie()
    {
      Veggie = "Sausage";
    }

    protected override void AddSauce()
    {
      Sauce  = "Marinara";
    }
      
    
    }
  }