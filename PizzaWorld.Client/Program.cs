﻿using System;
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
        User user = new User();

        // PrintAllStores();
        PrintAllStoresWithEF();
        user.SelectedStore = _sql.SelectStore();
        //_sql.CreateUser(user.SelectedStore);
        user.SelectedStore.CreateOrder();
        //_sql.Update(user.SelectedStore);
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

        //while user.SelectPizza()
        //user.Orders.Last().RemoveHawaiianPizza();
        // user.Orders.Last().RemoveMeatPizza();
        //user.Orders.Last().RemoveVeggiePizza();
        //_sql.Update(user.SelectedStore.Orders.Last());
        System.Console.WriteLine(user.SelectedStore.Orders.Last());
        System.Console.WriteLine(user);
        _sql.Update();
      }
    }
  }
}
