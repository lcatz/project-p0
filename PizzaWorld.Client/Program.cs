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

       

        static void Main(string[] args)
        {
            
            _client.MakeAStore();
            UserView();//this will create a store every time you begin the program
           // PrintAllStores();//moved to userview
            //System.Console.WriteLine(_client.SelectStore());//moved to userview
          
        }

        static void PrintAllStores()
        {
            foreach(var store in _client.Stores)
            {
                System.Console.WriteLine(store);
            }
        }

        static void UserView()
        {
            var user = new User();
            PrintAllStores();
            user.SelectedStore = _client.SelectStore();
            user.SelectedStore.CreateOrder();
            user.Orders.Add(user.SelectedStore.Orders.Last());
            
            System.Console.WriteLine(user);
        }
    }
}
