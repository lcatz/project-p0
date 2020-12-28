
using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
  public class AToppingModel : AEntity
  {
    public string Meat { get; set; }
    public string Veggie { get; set; }

    public string Sauce { get; set; }

    protected AToppingModel()
    {
      AddMeat();
      AddVeggie();
      AddSauce();
    }

    protected virtual void AddMeat() { }
    protected virtual void AddVeggie() { }
    protected virtual void AddSauce() { }
  }
}