using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();
        
      
        public IEnumerable<Store>  ReadStores()
        {
            return _db.Stores;
        }

        public Store ReadOne(string name)
        {
            return _db.Stores.FirstOrDefault(s => s.Name == name);
            // return _db.Stores.SingleOrDefault(s => s.Name == name);

            // var query = from s in _db 
            //             where s.Name == name
            //             select s;
        }

        public IEnumerable<Order> ReadOrders(Store store)
        {
            var s = ReadOne(store.Name);

            return s.Orders;
        }

        public void Save(Store store)
        {
           _db.Add(store);
          // _db.SaveChanges();
        }

        public void Update(Store store)
        {
            _db.SaveChanges();
        }

        public void CreateStore()
        {
            Save(new Store());
        }

        public Store SelectStore()
        {
            string input = Console.ReadLine();

            return ReadOne(input);
        }


    }
}