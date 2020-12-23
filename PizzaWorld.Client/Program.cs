using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
  class Program
  {
    private static readonly ClientSingleton _client = ClientSingleton.Instance;
    private readonly ClientSingleton _client2;

    private static readonly SqlClient _sql = new SqlClient();

    public Program()
    {
      _client2 = ClientSingleton.Instance;
    }

    static void Main(string[] args)
    {
      UserView();
    }

    static void PrintAllStores()
    {
      Console.WriteLine("\nPlease select a store.\n");//might be a better way/place to put this?
      foreach (var store in _client.Stores)
      {
        System.Console.WriteLine(store);
      }
    }

     static void PrintAllStoresWithEF()
    {
      Console.WriteLine("\nPlease select a store.\n");//might be a better way/place to put this?
      foreach (var store in _sql.ReadStores())
      {
        System.Console.WriteLine(store);
      }
    }

    static void UserView()
    {
      var user = new User();

      PrintAllStores();
      PrintAllStoresWithEF();

      user.SelectedStore = _client.SelectStore();
      user.SelectedStore.CreateOrder();
      user.Orders.Add(user.SelectedStore.Orders.Last());
      // while user.SelectPizza()
      user.Orders.Last().MakeMeatPizza();
      user.Orders.Last().MakeMeatPizza();

      System.Console.WriteLine(user);
    }
  }
}
