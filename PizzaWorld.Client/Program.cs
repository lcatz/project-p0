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
    private static readonly SqlClient _sql = new SqlClient();

    static void Main(string[] args)
    {
      _client.ChoosePrompt();
      UserView();
    }

    // static void PrintAllStores()
    // {
    //   Console.WriteLine("\nPlease select a store.\n");//might be a better way/place to put this?
    //   foreach (var store in _client.Stores)
    //   {
    //     System.Console.WriteLine(store);
    //   }
    // }

    static void PrintAllStoresWithEF()
    {

      foreach (var store in _sql.ReadStores())
      {
        System.Console.WriteLine(store);
      }
    }

    static void PrintOrdersOfStore(Store store)
    {
      foreach (var order in _sql.ReadOrders1(store))
      {
        System.Console.WriteLine(order);
      }
    }

    static void UserView()
    {

      Console.WriteLine("Please type 1 for Store, 2 for User");
      string InitialChoice = Console.ReadLine();
      if (InitialChoice == "1")
      {
        Console.WriteLine("Please enter the name of your store for orders (One, Two, Three)");
        Store StoreChoice = _sql.SelectStore();
        PrintOrdersOfStore(StoreChoice);
        Environment.Exit(0);
      }

      else if (InitialChoice == "2")
      {
        Console.WriteLine("Are you a returning (1) or new (2) user?");
        string NewOrReturning = Console.ReadLine();

        if (NewOrReturning == "1")
        {
          Console.WriteLine("Welcome back!  Please enter your user name.");
          string ReturningName = Console.ReadLine();
          User user = _sql.ReadUser(ReturningName);
          Console.WriteLine("Please type the name of the store you wish to worder from.");
          PrintAllStoresWithEF();
          user.SelectedStore = _sql.SelectStore();
          user.SelectedStore.CreateOrder();
          user.Orders.Add(user.SelectedStore.Orders.Last());
          string UserChoice = null;
          do{
          _client.PrintPizzaChoice();
          string AddPizza = Console.ReadLine();
          switch (AddPizza)
          {
            case "1":
            user.Orders.Last().MakeMeatPizza();
            break;

            case "2":
            user.Orders.Last().MakeVeggiePizza();
            break;

            case "3":
            user.Orders.Last().MakeHawaiianPizza();
            break;

            case "4":
            UserChoice = AddPizza;
            break;
          }
        }while (UserChoice != "4");

        string UserChoice2 = null;
        do{
            Console.WriteLine("Here is your order and order total.  To order, enter 4.  To delete a pizza, enter 1 (MeaPizza), 2 (VeggiePizza), 3 (Hawaiian Pizza)");
            System.Console.WriteLine(user);
            System.Console.WriteLine(user.SelectedStore.Orders.Last());
            string RemovePizza = Console.ReadLine();
            switch (RemovePizza)
          {
            case "1":
            user.Orders.Last().RemoveMeatPizza();
            break;

            case "2":
            user.Orders.Last().RemoveVeggiePizza();
            break;

            case "3":
            user.Orders.Last().RemoveHawaiianPizza();
            break;

            case "4":
            UserChoice2 = RemovePizza;
            break;
          }
        }while (UserChoice2 != "4");
        System.Console.WriteLine(user);
        System.Console.WriteLine(user.SelectedStore.Orders.Last());
        _sql.Update();
        }

        else if (NewOrReturning == "2")
        {
          Console.WriteLine("Welcome!  Please enter a username");
          string name = Console.ReadLine();
          User user = _sql.CreateUser(name);
          Console.WriteLine("Please type the name of the store you wish to worder from");
          PrintAllStoresWithEF();
          user.SelectedStore = _sql.SelectStore();
          user.SelectedStore.CreateOrder();

          user.Orders.Add(user.SelectedStore.Orders.Last());

          string UserChoice = null;
          do{
            _client.PrintPizzaChoice();
            string AddPizza = Console.ReadLine();
            switch (AddPizza)
            {
            case "1":
            user.Orders.Last().MakeMeatPizza();
            break;

            case "2":
            user.Orders.Last().MakeVeggiePizza();
            break;

            case "3":
            user.Orders.Last().MakeHawaiianPizza();
            break;

            case "4":
            UserChoice = AddPizza;
            break;
            }
          }while (UserChoice != "4");

          string UserChoice2 = null;
          do{
            Console.WriteLine("Here is your order and order total.  To order, enter 4.  To delete a pizza, enter 1 (MeaPizza), 2 (VeggiePizza), 3 (Hawaiian Pizza)");
            System.Console.WriteLine(user);
            System.Console.WriteLine(user.SelectedStore.Orders.Last());
            string RemovePizza = Console.ReadLine();
            switch (RemovePizza)
          {
            case "1":
            user.Orders.Last().RemoveMeatPizza();
            break;

            case "2":
            user.Orders.Last().RemoveVeggiePizza();
            break;

            case "3":
            user.Orders.Last().RemoveHawaiianPizza();
            break;

            case "4":
            UserChoice2 = RemovePizza;
            break;
          }
        }while (UserChoice2 != "4");
        System.Console.WriteLine(user);
        System.Console.WriteLine(user.SelectedStore.Orders.Last());
        _sql.Update();
        }
      }
    }
  }
}
